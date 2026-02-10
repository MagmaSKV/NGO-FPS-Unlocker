# Configuring BepInEx For Needy Streamer Overload / Needy Girl Overdose (ORIGINAL AUTOR: [amazeedaizee](https://gist.github.com/amazeedaizee/ae0dd70cc0d842d6a83cd80451e3752e), this is a backup from [here](https://gist.github.com/amazeedaizee/ae0dd70cc0d842d6a83cd80451e3752e).)

If you're interested in installing mods made for Needy Streamer Overload / Needy Girl Overdose using the BepInEx framework, this is the page for you!

This gist will go over how to install BepInEx, onto Needy Streamer Overload / Needy Girl Overdose.
It does not involve downloading mods itself and applying them to the game.

**Important**: If you're planning on loading mods using a Mac built with the Apple Silicon architecture (the M series), **you must have Rosetta installed.**

If you want to know more about BepInEx, here's the link to their GitHub page:
https://github.com/BepInEx/BepInEx

## Installing a preconfigured BepInEx package

Instead of doing everything manually, you can instead download a BepInEx package that's preconfigured with the game already with the link below:

> Note: In parentheses is the Unity version the game is built off of.
> If you don't see a link for an OS related to a specific version, that means the previous link before that version is still valid.

Here they are all listed: https://github.com/MagmaSKV/NGO-FPS-Unlocker/releases/tag/bepinex.1.0.0

**For version 1.4.0:**
<br/>
**(2022.3.42):**
<br/>
Mac: https://github.com/MagmaSKV/NGO-FPS-Unlocker/releases/download/bepinex.1.0.0/BepInEx_osx_NGO_v1_4_0.zip (uses Bepinex 5.4.23.2)
<br/> 
**(2022.3.22):**
<br/>
Windows: https://github.com/MagmaSKV/NGO-FPS-Unlocker/releases/download/bepinex.1.0.0/BepInEx_1_4_0.zip (uses Bepinex 5.4.23.2)

**For version 1.2.1+ (2022.3.15):**
<br/>
Windows: https://github.com/MagmaSKV/NGO-FPS-Unlocker/releases/download/bepinex.1.0.0/BepInEx_NGO_v1_2_1.zip
<br/>
Mac: https://github.com/MagmaSKV/NGO-FPS-Unlocker/releases/download/bepinex.1.0.0/BepInEx_osx_NGO_v1_2_1.zip


**For any version before 1.2.1 (2021.2.1):**
<br/>
Windows: https://github.com/MagmaSKV/NGO-FPS-Unlocker/releases/download/bepinex.1.0.0/BepinEx_NGO.zip
<br/>
Mac: https://github.com/MagmaSKV/NGO-FPS-Unlocker/releases/download/bepinex.1.0.0/BepInEx_osx_NGO.zip

You can check the comment or the description to see what version the package is using.

> **Note: If you are using a preconfigured BepInEx package that's meant for pre-version 1.2.1 of the game, just replacing your current unstripped_corlib folder with the one from the package meant for version 1.2.1 would work as well.**

To install, just open the game folder (.\\Steam\\steamapps\\common\\NEEDY GIRL OVERDOSE), and just extract the contents of the zip to there.  
  

The preconfigured Windows version has the BepInEx console enabled. If you see the BepInEx Console pop up when the game opens, that means BepInEx is installed successfully.

In the Mac version, if you want to play with mods, `run_bepinex.sh` should be run in a Terminal window in place of the game `.app` bundle, where the game will load with any installed mods. If the game executable itself is run instead, the game will load normally. The preconfigured Mac version also has the [WindoseXP](https://github.com/amazeedaizee/NeedyGirlXP) mod installed. You'll know if BepInEx is installed succesfully if the mod is able to load in the game.

> Note: If you can't run `run_bepinex.sh`, it might not have execute permissions. You can change this by executing the following in a Terminal window in the game folder:
```
chmod u+x run_bepinex.sh
```

If you want Steam to always load the modded version of the game, you can read the article below on how (non-Windows users only):
<br/>https://docs.bepinex.dev/articles/advanced/steam_interop.html

## Installing BepInEx manually

If you're choosing to install BepInEx manually, follow the steps below.

### 1. Get the latest version of BepInEx

First, go to the BepInEx releases page (https://github.com/BepInEx/BepInEx/releases), and download the latest version of BepInEx 5 **(do NOT download BepInEx 6)**. 

Then open the game folder (.\\Steam\\steamapps\\common\\NEEDY GIRL OVERDOSE), and just extract the contents of the zip to there.  

> **Note:** If you're using a Mac, Apple Silicon (the M series) is currently not supported officially with BepInEx. The preconfigured files above uses [this workaround](https://github.com/BepInEx/BepInEx/issues/513#issuecomment-1806574281) in order to load BepInEx into the game. [This guide might also help as well.](https://www.reddit.com/r/valheim/comments/1dcko3i/guide_running_mods_on_macos/)

When first looking at the BepInEx folder, only a `core` folder is shown. Normally all you have to do is just run the game, and then all the other folders (`plugins, config, etc`) will appear. However due to the way the game is shipped (reference: https://github.com/BepInEx/BepInEx/issues/418), BepInEx cannot be configured properly, so extra work has to be done.

### 2. Get assemblies from Unity Editor

To let BepInEx configure properly, we need to download the Unity Editor in the same version the game was made in, in this case, [2021.2.1](https://unity.com/releases/editor/whats-new/2021.2.1), or [2022.3.15](https://unity.com/releases/editor/whats-new/2022.3.15) or [2022.3.42](https://unity.com/releases/editor/whats-new/2022.3.42#notes).
#### Why do we need to do this?

Some game developers export Unity assemblies stripped (only exporting classes, functions, etc, that's used in the game) to lower their file size. It makes sense in a game dev perspective, as it's unnecessary to send out a game with extra bloat to the user. However, assembly stripping prevents BepInEx from configuring successfully. as there might be code that BepInEx needs access to that the game in its current state doesn't have.

We need the editor and import some of its assemblies so that BepInEx can be configured properly.

**You can read more about the above and how to get the necessary assemblies from the editor here: https://hackmd.io/@ghorsington/rJuLdZTzK**

> **Note:** If you're not using Windows for the steps provided in the link, you might need to extract the assemblies from the editor yourself. Note that you need [Unity Hub](https://unity.com/unity-hub) in order to use any version of Unity. One easy way to extract assemblies is to just create a new project (Universal 2D) in Unity Hub using an editor that's the same as the Unity version of the game, and then File > Build. The required assemblies will be found in the Managed folder of your newly built game files. Note that the game uses the Addressables package and the Localization package (for the 2022.3.42 version, the Localization package has to be excluded). You can download any packages you need through Window > Package Manager. 

If you followed the instructions from the link above, open the game in Windows, or run `run_bepinex.sh` on the Mac and see if the necessary folders show up (`plugins, config, etc`). If it does, that means BepInEx is successfully configured and installed with the game. You can change some settings with BepInEx by going into (.\\Steam\\steamapps\\common\\NEEDY GIRL OVERDOSE\\BepInEx\\config\\BepInEx.cfg). For instance, turning on the console can help if a mod is successfully loaded into the game.

## Conclusion

If you made it this far, the game should now be successfully installed with BepInEx! Feel free to try out any BepInEx-supported mod with the game to your hearts content.

To get started, why not try out the [WindoseXP](https://github.com/amazeedaizee/NeedyGirlXP) mod? It's purely a visual mod and doesn't affect the gameplay whatsoever, just to test the waters.

To apply any mod to the game, just place the mod into the BepInEx plugins folder.

Happy modding!
