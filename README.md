# CSV to ADIF Converter

![grafik](https://github.com/Stiles96/CSV-to-ADIF-Converter/assets/51234422/66a8b38e-f8ea-4ada-8df1-91b9f3285a2c)

## How to convert
1. Import your log as csv file
2. Create your ADIF Columns (use #<format> for special formating like time, date and frequency)
   a) Add columns by entering the name and format and press enter or click on "Add"
   b) Remove columns by marking in the list and press you delete key
3. Map you ADIF Columns with your CSV Columns (If you have more columns on one side than the other side the program will use the less column count side and the additional columns will be ignored)
4. (Optional) Add ADIF Default Values like "STATION_CALLSIGN" by clicking on "ADIF Default Values"
5. (Optional) Click on "Preview" to check your settings and log
6. Click on "Create ADIF" to save the .adi file

## Save and load your config
You can save your ADIF Columns and Default ADIF Values to a json file. Click on "Save ADIF Settings" to perform the action.
To load your config click on "Load ADIF Settings" and select your json file.

## Templates
Some ADIF Templates you can download from the templates folder and laod them to the program.
