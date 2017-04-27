# psx-box
![Alt text](  http://i.imgur.com/mkp3JJb.jpg "psx-box")

Progress 90 - 95% roughly
 
# What's already done?
 
 Memory has been implemented
 CD-Rom has been implemented 
 Input has been implemented
 SPU Code has been implemented
 CPU Decoder has been implemented
 Rendering code has been implemented
 Dma Core Code has been implemented
 Timing code has been implemented
 GPU Code has been implemented


## Work left to do

The User Interface



## Building psx-box


If you wish to build psx-box

psx-box requires SDL2 ("I Recommend installing it via nuget in Visual Studio)

Also please be aware that psxbox uses fopen which is as far as the compiler is concerned
is unsecure. Before building, You will need to go to properties --> C/C++ --> preprocessor --> Preprocessor Definitions and 
add in _CRT_SECURE_NO_WARNINGS

psx-box is free software licensed under GPLv3





