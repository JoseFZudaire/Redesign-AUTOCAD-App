// const { app, BrowserWindow, ipcMain } = require('electron')
// const {download} = require('electron-dl');
// const url = require('url')
// const path = require('path')

import { app, BrowserWindow, ipcMain } from 'electron';
import {download} from 'electron-dl';
import url, {fileURLToPath} from 'url';
import path, {dirname} from 'path';

let mainWindow
const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);

function createWindow() {

    mainWindow = new BrowserWindow({
        width: 1000,
        height: 860,
        minWidth: 1000,
        minHeight: 860,
        show: false,
        backgroundColor: '#312450',
        icon: "./public/img/Hitachi-logo.ico",
        webPreferences: {
            nodeIntegration: true
        }
    })

    mainWindow.loadURL(url.format({
        pathname: path.join(__dirname, './public/index.html'),
        protocol: 'file:',
        show: false,
        slashes: true        
    }));

    ipcMain.on("download", (event, info) => {
        download(BrowserWindow.getFocusedWindow(), info.url, info.properties)
            .then(dl => window.webContents.send("download complete", dl.getSavePath()));
    })

    mainWindow.once('ready-to-show', () => {
        mainWindow.show();
        mainWindow.focus();
    });

    mainWindow.on('closed', () => {
        mainWindow = null
    })
}

app.on('ready', createWindow)

app.on('window-all-closed', () => {
    if (process.platform !== 'darwin') {
        app.quit()
    }
})

app.on('activate', () => {
    if (mainWindow === null) {
        createWindow()
    }
})

