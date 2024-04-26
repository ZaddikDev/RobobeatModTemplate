# ROBOBEAT Mod Template
A ROBOBEAT Demo mod template to create your own mods.

> This README is a copy of [this](https://github.com/ZaddikDev/TrackEditorOverhaul) repository, please, open an isse if something seems wrong

## Building
To build this project, you need:
- A [copy of ROBOBEAT Demo](https://store.steampowered.com/app/1456760/ROBOBEAT/) (ROBOBEAT will be supported on release)
- A [copy of BepInEx](https://github.com/BepInEx/BepInEx/releases)
- Visual Studio Community 2022 with the .NET desktop development workload
- A repository using [this template](https://github.com/ZaddikDev/RobobeatModTemplate)

After obtaining all of the requirements above, you first need to install BepInEx into the ROBOBEAT Demo folder. To do that, I would recommend checking out [this article](https://docs.bepinex.dev/articles/user_guide/installation/index.html).
After installing it, you need to run the game at least once to generate configuration files and folders.

### Downloading the mod's source code
There are lots of ways to do this. These are 2 of the most popular options:
- **Using [git](https://git-scm.com/):** This is the most popular one and the one I recommend. To use this method, just install it (if you haven't already) and use the command `git clone`, with either the link of your mod's repository or this repository. For demonstration purposes, I'm going to use this repository, but you can (and should) use your own. The command would be: `git clone https://github.com/ZaddikDev/RobobeatModTemplate`. After that, a new folder will be created containing the source code.
- **Downloading the code as .zip:** This is an option, but it it's not the recommended one. Simply head to the repository's source code page and click the green button that reads "Code" and press Download ZIP.

![zip-help-image](https://github.com/ZaddikDev/TrackEditorOverhaul/assets/63800482/ec4f47b2-3e2e-48f1-9ba3-3c95eab6c8b0).

After obtaining all of the requirements above, you need to run `setup_env.bat`, to setup a build environment. This is required, as it copies necessary files such as Unity code and game code.

Finally, after all these steps above, you can finally build your project. Simply open the solution in Visual Studio and right click the project->Build. The mod's DLL file will be built in `bin/Debug/RobobeatModTemplate.dll`

![project right click and build image](https://github.com/ZaddikDev/TrackEditorOverhaul/assets/63800482/b3db0a12-4e25-48c4-960d-7a762efe8b2a)

### Congratulations! Now you can develop your own mod