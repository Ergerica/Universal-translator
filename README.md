# Universal-translator
This project will make conversions from Meters, Kilometers and centimeters to these same ones.

In this project, a txt file will be read and this txt file will contain a value, unit of orgin , what the origignal unit will be converted to, all seperated by spaces, each unit will be made in abbreviated form
meaning:
Kilometers: KM
Meters: M
Centimeters: CM
Example:
110 KM M
This means that we would like to know the equivalent of 110 Kilometers in meters.
The output of this program will be another text file printing out the answer for each desired conversion:
110 KM M 110000
where 110000 is the result of 110km to 110000 in meters
The instructions to use this are:
1. OPen the project in vs code making sure to have .net sdk installed to be able to compile
2. When running the project you must make sure that when you write the path of the file you also follow it with with the name of the file: 
ie: let's say the file you would like to read from is in this path
"/home/erica/Documents/Universal-translator" you must write the name of the file after this like
"/home/erica/Documents/Universal-translator/testdoc" this is the full path to the file
3. when looking for the final results check in the .txt where you chose to save it to find it.
