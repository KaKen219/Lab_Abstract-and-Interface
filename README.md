                   <<abstract>>
                      Person
------------------------------------------------
- FirstName : string
- LastName  : string
- Phone     : string
- Email     : string
------------------------------------------------
+ Register() : void
+ ShowInfo() : void
------------------------------------------------
        ▲
        │
 ┌──────┼───────────────┐
 │      │               │
 │      │               │
Student Teacher     GeneralPerson
Student
---------------------------------
- Major : string
- StudentID : string
---------------------------------
+ ShowInfo() : void
---------------------------------
Inheritance: Student → Person
Teacher
---------------------------------
- Major : string
- AcademicRank : string
---------------------------------
+ ShowInfo() : void
+ Train() : void
+ Approve(p : Person) : void
---------------------------------
Inheritance: Teacher → Person
Implements: ISpeaker
GeneralPerson
---------------------------------
- Workplace : string
- Position  : string
---------------------------------
+ ShowInfo() : void
+ Train() : void
+ Approve(p : Person) : void
---------------------------------
Inheritance: GeneralPerson → Person
Implements: ISpeaker

<<interface>>
ISpeaker
---------------------------------
+ Train() : void
+ Approve(p : Person) : void
