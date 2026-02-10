# NGO-FPS-Unlocker
 Mod to remove the FPS limit in Needy Girl/Streamer Overdose

NEEDY GIRL/STREAMER OVERDOSE, from version 1.2.0 onwards, has an FPS limit (from what I've researched, it was the first version to have this limit).

The limit is half the refresh rate of your monitor (for example: 60Hz = 30fps / 75Hz = 38fps / 120Hz = 60fps).

This mod removes the FPS limit using `vSyncCount = 0` (disabling vSync, which is the main reason) and `targetFrameRate = FPS` (to limit it to a desired amount later).

It allows you to limit it to any value you want from the configuration file, such as 60, 144, 240, etc. **(default: 144)**.

📝 If you want to completely remove the FPS limit, put "-1" in the FPS field, although you can also put a very high number.

This works from version 1.2.0 to 1.4.0 (latest) (to see your version, start the game and it will show you your version in the upper right corner)

<img width="1920" height="1080" alt="versions" src="https://github.com/user-attachments/assets/c64c4590-6cb0-48e1-9ae8-43fe028b1594" />

[1. Installation](#installation)

[2. Requirements](#requirements)

[3. Usage](#usage)

[4. Compilation](#compilation)

[5. Troubleshooting](#troubleshooting)

# Installation

[Github Latest Release](https://github.com/MagmaSKV/NGO-FPS-Unlocker/releases) **(recommended)**

or

`git clone https://github.com/MagmaSKV/NGO-FPS-Unlocker` **(need compilation) (Follow the steps in the [compilation](#compilation) section)**

# Requirements

- [NEEDY GIRL OVERDOSE](https://store.steampowered.com/app/1451940) (obviously)
- BepInEx ([the official versions](https://github.com/BepInEx/BepInEx/releases), or a [pre-configured package created by amazeedaizee](https://gist.github.com/amazeedaizee/ae0dd70cc0d842d6a83cd80451e3752e#installing-a-preconfigured-bepinex-package) **(it has the installation steps)** (this one worked for me, but you can use the official one if you prefer)) (If the creator deletes the gist, [I made a copy just in case](https://github.com/MagmaSKV/NGO-FPS-Unlocker/howtobepinex-Backup.md#installing-a-preconfigured-bepinex-package). The downloads are the same as his, but I uploaded it myself. If his is available, use it! :D)

# Usage

1. Download BepInEx (it's listed in the [requirements](#requirements), including installation instructions). **(If you're PLAYING on Linux, the installation steps are the same as on Windows, but you might need to do the first thing mentioned in [troubleshooting](#troubleshooting).)**

2. Extract the BepInEx compressed file to the game's root directory **(the BepInEx folder must be in the same directory as Windose.exe)**

3. Move the mod (FPS Unlocker.dll) to: `NGO_folder/BepInEx/plugins/`

4. Start the game. You should see a command prompt window open. If so, BepInEx has loaded and will likely load the mod. If not, check the [troubleshooting](#troubleshooting) section.

<img width="656" height="425" alt="bepinex_loaded" src="https://github.com/user-attachments/assets/582c186b-c2fa-43ec-8d55-2920d597f093" />

5. You should see that the game is no longer running at the limited FPS it was before (you can use various tools to check the FPS, such as [MSI Afterburner](https://www.msi.com/Landing/afterburner/graphics-cards), Windows Game Bar using the performance tab, or [dxvk](https://github.com/doitsujin/dxvk/releases) (see [troubleshooting](#troubleshooting) section). You can even use [MangoHUD](https://github.com/flightlessmango/MangoHud) and [dxvk](https://github.com/doitsujin/dxvk/releases) (yes, again) if you're using Linux). If the FPS doesn't change, check [troubleshooting](#troubleshooting).

<img width="1920" height="708" alt="fps_all_versions" src="https://github.com/user-attachments/assets/cdb6678e-bbe6-4561-ac81-aea8381ce26b" />

📝 You can change the FPS in real time (without having to reopen the game)

**Before:**

<img width="953" height="751" alt="fps_before_realtime" src="https://github.com/user-attachments/assets/e2fb2552-95a3-43c4-899c-0d46d4079167" />

**After:**

<img width="973" height="755" alt="fps_after_realtime" src="https://github.com/user-attachments/assets/9a75c5f9-2d15-4ddf-b7e4-c28cc58f7719" />

# Compilation

## Requirements

### Windows
- [git](https://git-scm.com/install/windows)
- [dotnet](https://dotnet.microsoft.com/download) **(After installing it, use `dotnet --version` to ensure it was installed correctly.)**

### Linux
- [git](https://git-scm.com/install/linux)
- [dotnet](https://learn.microsoft.com/dotnet/core/install/linux) **(After installing it, use `dotnet --version` to ensure it was installed correctly.)**

📝 Find your distribution (like Ubuntu) and use the command they give you; if it's not there, just search for "dotnet/git (distribution)" (for example: "dotnet/git arch linux")
# 

⚠️ I haven't tested it on Windows, so I don't know if these commands will be accurate! I only compiled it on Linux, so my recommendation is to use [Docker](https://www.docker.com/), [WSL](https://learn.microsoft.com/es-es/windows/wsl/install), or even [Termux](https://f-droid.org/packages/com.termux/) using an Android emulator (like [MuMu Player](https://www.mumuplayer.com/es/), [Android Studio AVDs](https://developer.android.com/studio/run/managing-avds), [Bluestacks](https://www.bluestacks.com/es/index.html)), or any similar application if you encounter errors and don't understand how to fix them. 

📝 The commands should be the same whether you use PowerShell (Windows) or Linux; if it's cmd (Windows), the **`rm`** command will change to **`del`** and the **`/`** in the directories (like: `bin/Release/...`) would be `bin\Release\...` (as far as I know, this is only in **cmd**; I remember that powershell is like Linux)

1. Install BepInEx, as stated in the [requirements](#requirements). **(If you're PLAYING on Linux, the installation steps are the same as on Windows, but you might need to do the first thing mentioned in [troubleshooting](#troubleshooting).)**

2. In terminal (Linux) or cmd/powershell (Windows) **(powershell recommended)**: `cd NGO_folder/BepInEx/plugins/`

3. Clone the repository: `git clone https://github.com/MagmaSKV/NGO-FPS-Unlocker`

4. `cd NGO-FPS-Unlocker`

⚠️ If you need to recompile, you must first delete what was previously generated: `rm -rf bin obj`

5. `dotnet build -c Release`

6. `cp "bin/Release/net472/FPS Unlock.dll" ..`

7. Open the game and try the mod :D

# Troubleshooting

- If you're playing on Linux, make sure to add the following to your Steam startup parameters:

`WINEDLLOVERRIDES="winhttp=n,b" %command%`

Or, if you're using Bottles or Lutris (I think), you can directly add the DLL modifications to **"winhttp"** in **"Native, Built-in"**

⚠️ Otherwise, BepInEx will never load.

- If your FPS doesn't increase or the mod isn't working, try [compiling it](#compilation). This can happen if Unity doesn't have the necessary references to `vSyncCount` or `targetFrameRate`, but I don't think that will change. If you want to know which version of Unity your game version uses, you can use: `strings UnityPlayer.dll | grep -E '20[0-9]{2}\.[0-9]+\.[0-9]+[abfpc][0-9]+([_ ][a-z0-9]+)?(\s*\([a-z0-9]+\))?'` in the game's root folder. (The versions shown in the image below are 100% compatible. This could happen with a different version, but I highly doubt it.)

<img width="1123" height="422" alt="unity_versions" src="https://github.com/user-attachments/assets/e8a83f42-8233-4706-9890-9b200048fac0" />

📝 On Windows, it can be installed from: https://learn.microsoft.com/en-us/sysinternals/downloads/strings

- If BepInEx doesn't open, check that you have the correct files. Apparently, newer versions of BepInEx don't work with some versions, at least in my case, which is why I used the pre-configured package. It has versions prior to 1.2.1 (<1.2.0), 1.2.1+ (1.3.0), and 1.4.0.

⚠️ If you use the wrong one, it will crash, likely leaving a .log file in the game's root directory starting with `preloader_`.

📝 You can use the command above to see your game's Unity version by looking at the strings in the `UnityPlayer.dll` file located in your game directory.

- If you want to hide the command prompt **(If you close it, the game closes)** (recommended if you've already verified it works), edit `NGO_folder/BepInEx/config/BepInEx.cfg` and look for (In my case it's from line 43 to 48, but it could vary):

```
[Logging.Console]
## Enables showing a console for log output.
# Setting type: Boolean
# Default value: false
Enabled = true
```

Change `true` to `false` and the command prompt will no longer open.

**Enabled = true**

<img width="1023" height="234" alt="console_true" src="https://github.com/user-attachments/assets/bf64ece5-b317-473e-bc1c-929e6349144a" />

**Enabled = false**

<img width="748" height="267" alt="console_false" src="https://github.com/user-attachments/assets/adffa75b-aa1c-4a01-b5d8-ae5f3670b191" />

If you encounter any problems or want to suggest an option, just create an issue and say what you want. I'll try to answer as soon as possible :D

#

⚠️ The mod uses [System.Reflection](https://learn.microsoft.com/en-us/dotnet/api/system.reflection?view=net-10.0) to detect the game's assemblies directly. This is because when I first implemented it in version 1.2.0, it worked but not in other versions. So, I was going to separate the downloads into versions 1.3.0 and 1.4.0, but when compiling, I encountered errors related to missing `vSyncCount` and `targetFrameRate`. Therefore, to improve the mod and ensure it works across all versions, I decided to use [System.Reflection](https://learn.microsoft.com/en-us/dotnet/api/system.reflection?view=net-10.0), which detects the assemblies directly upon execution.

📝 I wanted to say this because [System.Reflection](https://learn.microsoft.com/en-us/dotnet/api/system.reflection?view=net-10.0) is sometimes used for malware (It's not malware itself, but its functions could be used to hide malware.)

📝 You can investigate further on Google; I mention this mainly in case your antivirus alerts you or something similar (which I doubt). You can look at the code and you'll see that it doesn't do anything like steal data or anything like that; it's only used to search for `QualitySettings.vSyncCount` and `Application.targetFrameRate`.
