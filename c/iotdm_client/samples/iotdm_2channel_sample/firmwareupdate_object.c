

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

//
// Simple implementation of IoTHub LWM2M Firmware Update object
//

//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.

#include <stdio.h>
#include <string.h>
#include <stdlib.h>

#if defined(WIN32)
#include <windows.h>
#include <tchar.h>
#endif

#include "iothub_lwm2m.h"
#include "iotdm_lwm2m_client_apis.h"
#include "liblwm2m.h"

/*
state machine implemented by this file
--------------------------------------

initial conditions:
state = 1
result = 0

step 1: server sets URI
state=2
simulated download starts

step 2: simulated download completes:
state=3

step 3: server starts update 
<no properties change>

step 4: update is complete
result=1
state=1

on upgrade faulure:
result=error from 2-7
state=1
*/

#define STATE_IDLE 1
#define STATE_DOWNLOADING 2
#define STATE_DOWNLOAD_COMPLETE 3

#define UPDATE_RESULT_DEFAULT 0
#define UPDATE_RESULT_SUCCESS 1

/**********************************************************************************
 * Callback prototypes
 *
 **********************************************************************************/

IOTHUB_CLIENT_RESULT on_write_firmwareupdate_package(void* value);
IOTHUB_CLIENT_RESULT on_write_firmwareupdate_packageuri(STRING_HANDLE value);
IOTHUB_CLIENT_RESULT on_execute_firmwareupdate_update();
IOTHUB_CLIENT_RESULT on_read_firmwareupdate_state(int *value);
IOTHUB_CLIENT_RESULT on_read_firmwareupdate_updateresult(int *value);
IOTHUB_CLIENT_RESULT on_read_firmwareupdate_pkgname(STRING_HANDLE *value);
IOTHUB_CLIENT_RESULT on_read_firmwareupdate_pkgversion(STRING_HANDLE *value);

/**********************************************************************************
 * Default property implmentations
 *
 **********************************************************************************/
void* propval_firmwareupdate_package = NULL;
STRING_HANDLE propval_firmwareupdate_packageuri = NULL;
int propval_firmwareupdate_state = STATE_IDLE;
int propval_firmwareupdate_updateresult = UPDATE_RESULT_DEFAULT;
STRING_HANDLE propval_firmwareupdate_pkgname = NULL;
STRING_HANDLE propval_firmwareupdate_pkgversion = NULL;

void set_default_firmwareupdate_values()
{
    propval_firmwareupdate_packageuri = STRING_construct("_");
    propval_firmwareupdate_state = STATE_IDLE;
    propval_firmwareupdate_updateresult = UPDATE_RESULT_DEFAULT;
    propval_firmwareupdate_pkgname = STRING_construct("_");
    propval_firmwareupdate_pkgversion = STRING_construct("_");
}

/**********************************************************************************
 * CALLBACK REGISTRATION
 *
 **********************************************************************************/
IOTHUB_CLIENT_RESULT register_all_firmwareupdate_callbacks(IOTHUB_CHANNEL_HANDLE h)
{
    if (
        (IOTHUB_CLIENT_OK != IotHubClient_FirmwareUpdate_Package_SetWriteCallback(h, on_write_firmwareupdate_package)) ||
        (IOTHUB_CLIENT_OK != IotHubClient_FirmwareUpdate_PackageUri_SetWriteCallback(h, on_write_firmwareupdate_packageuri)) ||
        (IOTHUB_CLIENT_OK != IotHubClient_FirmwareUpdate_Update_SetExecuteCallback(h, on_execute_firmwareupdate_update)) ||
        (IOTHUB_CLIENT_OK != IotHubClient_FirmwareUpdate_State_SetReadCallback(h, on_read_firmwareupdate_state)) ||
        (IOTHUB_CLIENT_OK != IotHubClient_FirmwareUpdate_UpdateResult_SetReadCallback(h, on_read_firmwareupdate_updateresult)) ||
        (IOTHUB_CLIENT_OK != IotHubClient_FirmwareUpdate_PkgName_SetReadCallback(h, on_read_firmwareupdate_pkgname)) ||
        (IOTHUB_CLIENT_OK != IotHubClient_FirmwareUpdate_PkgVersion_SetReadCallback(h, on_read_firmwareupdate_pkgversion)) ||
        false
        )
    {
        LogError("Failure setting callback in Firmware Update object\r\n");

        return IOTHUB_CLIENT_ERROR;
    }

    return IOTHUB_CLIENT_OK;
}

/**********************************************************************************
 * OBJECT REGISTRATION
 *
 **********************************************************************************/
IOTHUB_CLIENT_RESULT register_firmwareupdate_object(IOTHUB_CLIENT_HANDLE h)
{
    set_default_firmwareupdate_values();
    if (IOTHUB_CLIENT_OK != register_all_firmwareupdate_callbacks(h))
    {
        LogError("setting default values for Firmware Update object\r\n");

        return IOTHUB_CLIENT_ERROR;
    }

    if (IOTHUB_CLIENT_OK != IoTHubClient_DM_AddNewObject(h, 5))
    {
        LogError("Failure to add the Firmware Update object for client: %p\r\n", h);

        return IOTHUB_CLIENT_ERROR;
    }

    return IOTHUB_CLIENT_OK;
}

/**********************************************************************************
 * CALLBACK HANDLERS
 *
 **********************************************************************************/
IOTHUB_CLIENT_RESULT on_write_firmwareupdate_package(void* value)
{
    LogInfo("inside writer for FirmwareUpdate_Package\r\n");


    return IOTHUB_CLIENT_OK;
}

int download_counter = 0;
IOTHUB_CLIENT_RESULT on_write_firmwareupdate_packageuri(STRING_HANDLE value)
{
    LogInfo("inside writer for FirmwareUpdate_PackageUri\r\n");

    LogInfo("setting to [%s]\r\n", STRING_c_str(value));
    STRING_copy(propval_firmwareupdate_packageuri, STRING_c_str(value));

    if (STRING_length(value) == 0)
    {
        LogInfo("** empty URI received.  Resetting to idle state\r\n");
        propval_firmwareupdate_state = STATE_IDLE;
        propval_firmwareupdate_updateresult = UPDATE_RESULT_DEFAULT;
    }
    else
    {
        // enter step 1: start downloading
        LogInfo("** URI received.  Starting simulated download\r\n");
        propval_firmwareupdate_state = STATE_DOWNLOADING;
        download_counter = 0;
    }

    return IOTHUB_CLIENT_OK;
}

int update_counter = 0;
bool update_in_progress = false;
IOTHUB_CLIENT_RESULT on_execute_firmwareupdate_update()
{
    LogInfo("inside execute handler for FirmwareUpdate_Update\r\n");
    if (propval_firmwareupdate_state == STATE_DOWNLOAD_COMPLETE)
    {
        // Enter step 3: simulated update starts
        update_counter = 0;
        update_in_progress = true;
        LogInfo("** Simulated update started\r\n");
    }
    else
    {
        LogInfo("** INVALID - can't update until firmware download is complete\r\n");
    }
    return IOTHUB_CLIENT_OK;
}

IOTHUB_CLIENT_RESULT on_read_firmwareupdate_state(int *value)
{
    LogInfo("inside reader for FirmwareUpdate_State\r\n");


    if (propval_firmwareupdate_state == STATE_DOWNLOADING)
    {
        if (download_counter++ >= 4)
        {
            // enter step 2: download complete
            LogInfo("** Download complete\r\n");
            propval_firmwareupdate_state = STATE_DOWNLOAD_COMPLETE;
        }
        else
        {
            LogInfo("** Downloading...\r\n");
        }
    }

    LogInfo("returning %d\r\n", propval_firmwareupdate_state);
    *value = propval_firmwareupdate_state;

    return IOTHUB_CLIENT_OK;
}

IOTHUB_CLIENT_RESULT on_read_firmwareupdate_updateresult(int *value)
{
    LogInfo("inside reader for FirmwareUpdate_UpdateResult\r\n");

    if (update_in_progress)
    {
        if (update_counter++ >= 4)
        {
            // enter step 4: update complete
            LogInfo("** Update complete\r\n");
            update_in_progress = false;
            propval_firmwareupdate_state = STATE_IDLE;
            propval_firmwareupdate_updateresult = UPDATE_RESULT_SUCCESS;
        }
        else
        {
            LogInfo("** Updating..\r\n");
        }
    }
    
    LogInfo("returning %d\r\n", propval_firmwareupdate_updateresult);
    *value = propval_firmwareupdate_updateresult;

    return IOTHUB_CLIENT_OK;
}

IOTHUB_CLIENT_RESULT on_read_firmwareupdate_pkgname(STRING_HANDLE *value)
{
    LogInfo("inside reader for FirmwareUpdate_PkgName\r\n");

    LogInfo("returning [%s]\r\n", STRING_c_str(propval_firmwareupdate_pkgname));
    *value = propval_firmwareupdate_pkgname;

    return IOTHUB_CLIENT_OK;
}

IOTHUB_CLIENT_RESULT on_read_firmwareupdate_pkgversion(STRING_HANDLE *value)
{
    LogInfo("inside reader for FirmwareUpdate_PkgVersion\r\n");

    LogInfo("returning [%s]\r\n", STRING_c_str(propval_firmwareupdate_pkgversion));
    *value = propval_firmwareupdate_pkgversion;

    return IOTHUB_CLIENT_OK;
}


