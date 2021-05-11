# AgeAndGender_ConsolePoject

# nb : some instructins are written in french

This is a console application project written in c# and consist on 
asking to the user to input a choice between M for men and W for women.
and then the user enter the age and if it'seuanl or greater than 18 (majority age), the console display Men, else if the age is less than 18, the console display boy. Same thing for the opposite gender.

pseudo code :

constant int majorityAgeFR <- 18

gender <- input("M" for men or "W" for women)

while gender not equal "M" And gender not equal "W" 
        gender <- input("M" or "W")
end while

age <- input(age as integer )

while age < 0
        age <- input(age greater than 0)

if gender equals "M" and age>=majorityAgeFR
        display "Men"
else if gender equals "W" and age>=majorityAgeFR
        display "women"
else if gender equals "M" and age< majorityAgeFR
        display "boy"
else if gender equals "W" and age< majorityAgeFR
        display "girl"