makepal

Author: Rob Bryant

Website: https://slydogstudios.org

Email: slydogstudios@gmail.com


====================================================================
WHAT THIS PROGRAM DOES                                              |
====================================================================
A way to make palette data tables for use in your Nintendo          |
Entertainment System homebrew games.                                |
====================================================================


====================================================================
USAGE                                                               |
====================================================================
Click on a color you wish to use, then click on an empty square     |
in the place you would like to use that color. The first color of   |
each set of four will always be the same, so when you click one,    |
the rest of them fill in as well. After you have filled the entire  |
palette, click the 'Get Table' button to see a table of data that   |
is usable in your code (ca65 syntax is used). If you would like the |
name of your data table to be different than the default (palette), |
then you must change the name under 'Label Name' before clicking    |
the 'Get Table' button. To reset your palette, click the 'Clear     |
Palette' button. Everything you have done to that point will be     |
erased.                                                             |
                                                                    |
Extra info:                                                         |
                                                                    |
* Any squares that you do not fill in with a color will default to  |
   $0f when you push the 'Get Table' button.                        |
* Upon clicking the 'Get Table' button, the data table that you     |
   created will automatically be copied to your clipboard.          |
* The Escape (ESC) key will exit the program.                       |
====================================================================


====================================================================
DEPENDANCIES                                                        |
====================================================================
It's built using VB.NET, so it's intended for machines running      |
Windows. The .NET Framework 1.1 is required to run it. This program |
has been tested on Windows 7, 8, and 8.1.                           |
====================================================================

EOF