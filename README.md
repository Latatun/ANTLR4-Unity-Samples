# ANTLR4 SAMPLES

### AVAILABLE SAMPLES
- [Hello World](./Assets/Samples/Hello_World)

### SUMMARY
- **Unity version**: 2021.3.29f1
- **ANTLR4 version**: 4.13.1

### STEPS
1. First install the [extension](https://marketplace.visualstudio.com/items?itemName=mike-lischke.vscode-antlr4) for Visual Studio Code (vscode)
2. Once installed, go to File>Preferences>Settings, there search for Antlr4 and edit the settings in JSON for **Generation**, change *language* to *CSharp*
3. You could now test this part, but all files are already generated. Remove them if you want and save the *Hello.g4* file to see them generated again, if the *mode* inside settings was left to internal, it will create them inside .antlr folder
4. To use it on Unity, we need the runtime dll, you can either download it [here](https://www.nuget.org/packages/Antlr4.Runtime.Standard/4.13.1) or by using one of the methods inside that link.
Now create a folder called *Plugins* inside *Assets* and store the library file there (maybe you need to restart vscode to apply the changes if it's open during this part)
5. (OPTIONAL) You can also create a file called *csc.rsp* at the root of *Assets* folder and add this line **-nowarn:3021** to hide this warning from the generated scripts
6. And everything should be set, you can now go to the *HelloWorld* scene and run it to see a console message using ANTLR4 and/or try out some of the tasks provided by the extension

### TROUBLESHOOTING
Sometimes the rules are not recognized and you cannot test them using the proper command, simply make a small change in the file (like a line break, whitespace, etc.) and save again

It's also frequent that generated classes are not picked up by vscode, simply restart the IDE

### RESOURCES
- [ANTLR4 Mega Tutorial](https://tomassetti.me/antlr-mega-tutorial)
- [Create a Text Parser in C# with ANTLR](https://www.youtube.com/watch?v=lc9JlXyBG4E)
- The Hello World example was taken from the book *The Definitive ANTLR4 Reference*
