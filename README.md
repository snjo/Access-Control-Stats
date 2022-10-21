# Access-Control-Stats

This program counts the number of unique entries in a CSV file, looking at the two first entries on each line.  
It converts the first entry on each line from a date and time to just the date.  
It counts how many unique names appear per day.  

It will skip the first line of the CSV, assuming it is the column names.

## Example input file:
"Date/time";"User";"Other fields"  
"2022-10-21 12:35:10";"John Doe";"Ignored data"  
"2022-10-21 12:32:00";"Andrew Tom";"Ignored data";"Bla bla"  
"2022-10-21 12:20:00";"Willemina Phlum";"Ignored data"  
"2022-10-21 08:34:50";"John Doe"  
"2022-10-20 08:04:50";"John Doe"  
"2022-10-19 08:34:50";"Laminar Plough"  

## Output:
2022-10-21 : 3  
2022-10-20 : 1  
2022-10-19 : 1  
