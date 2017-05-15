# psx-box
![Alt text](  http://i.imgur.com/mkp3JJb.jpg "psx-box")

Progress 95 - 99.9% roughly
 

# What's already been done?

Alot of the front-end work has already been finished. psx-box is a project that will
incorporate mutliple emulation backends similar to how retroarch uses different
libretro cores. Currrently we are working towards implementing a number of cores
beginning with PSXACT as our first. We have other cores or PS1 Emulators if you will
that we would like to use as well which will be added to the project in the future.
Our design methodology is to load the cores as a library and psx-box will interact 
with the core emulation code that way. This has the benefit of better compatibility 
for games as users will be able to select from multiple backends, as well as keeping
the codebase very small and easy to maintain.


# Current state of the Project

Work on The U.I. is mostly finished. Still need to implement the backend stuff

![Alt text](  http://i.imgur.com/2ONDlMw.png "psx-box")



# Building psx-box

Building psx-box is pretty straightforward. Just git clone open up the .sln file
and build. Nothing more, nothing less.


psx-box is free software licensed under GPLv3





