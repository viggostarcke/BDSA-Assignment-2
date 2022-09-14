# Assignment #2

## C♯

Clone this repository and bring the code pieces you need into your BDSA Assignments GitHub repository.

### Classes

In a new *class library* implement a *class* `Student` with the following properties:

- Id : `int`
- GivenName : `string`
- Surname : `string`
- Status : `Status` (enum: `New`, `Active`, `Dropout`, `Graduated`)
- StartDate : `DateTime`
- EndDate : `DateTime`
- GraduationDate : `DateTime`

And the following rules:

- Status is only readable - figure out the business rules given the three dates compared to `DateTime.Now`.
- Id can only be set when the class is created
- Implement a nice `ToString()` method

**Note**: Remember to do this Test-Driven - so create an xunit test library and implement the required tests there.

### Records

(cf. CSN chapter 4 section *Records*)

Implement a new *record* `ImmutableStudent` with the same rules as above, only now all properties must be *immutable* and set through the constructor.

Write a couple of tests where you test the built-in equality comparer and to string properties of a *record*.

### Types

Consider the four different constructs in C♯:

1. Class
1. Struct
1. Record Class
1. Record Struct

Explain some of the key differences between the three and give examples of where you would use each of them.

Write your answers in the final .pdf file.

### Extension Methods

Consider the two methods you implemented last week:

```csharp
IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items);

IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate);
```

Given the following collections in scope:

```csharp
IEnumerable<int>[] xs;

int[] ys;
```

Solve the following questions with extension methods (one-liners):

1. Flatten the numbers in `xs`.
1. Select numbers in `ys` which are divisible by `7` and greater than `42`.
1. Select numbers in `ys` which are *leap years*.

Write the answers in the .pdf file with all non-code solutions.

Implement and test the following extension methods:

1. A method `IsSecure` which extends `Uri` and returns true if the `Uri` is using *Secure Hypertext Transfer Protocol*.
1. A method `WordCount` which extends `string` and returns the number of words in the string. Note a word can only contain *unicode letters* (no numbers or symbols).

Use the supplied `Extensions.cs` and `ExtensionsTests.cs` files.

### Delegates / Anonymous methods

Implement the following anonymous functions using the built-in delegates and lambda expressions:

1. A method which takes a string and prints the content in reverse order (by character)
1. A method which takes two decimals and returns the product
1. A method which takes a whole number and a string and returns `true` if they are numerically equal. Note that the string `"  0042"` should return true if the number is `42`

Write the answers in the .pdf file with all non-code solutions.

You probably want to implement a set of tests to validate the methods.

Use the supplied `DelegatesTests.cs` file.

### LINQ

Prerequisite: Extend the `Wizards.csv` file with at least 10 wizard of your choosing to enable the queries above.
Examine the `Wizard` class and its corresponding unit test class.

Then, given the supplied `Wizard` record and `WizardCollection` class, use the supplied `Queries.cs` and corresponding tests class to implement and test the following queries using LINQ:

(You need to wrap the queries in suitable methods for testing)

1. Wizards invented by *Rowling*. Only return the names.
1. The year the first *sith lord* was introduced. Let's define a *sith lord* to be one named Darth *something*.
1. Unique list of wizards from the *Harry Potter* books - only return name and year (as a value tuple).
1. List of wizard names grouped by creator in reverse order by creator name and then wizard name.

Each method *must* be implemented twice - once using only *extension methods* and once using as much *LINQ* as possible.

Also, take some time to investigate and try to understand the implementation of `WizardCollection`.

## Software Engineering (1)

### Exercise 1

What is the difference between a scenario and a use case? When do you use each construct?

### Exercise 2

Draw a use case diagram for a ticket distributor for a train system. The system includes two actors: a traveler, who purchases different types of tickets, and a central computer system, which maintains a reference database for the tariff. Use cases should include: **BuyOneWayTicket**, **BuyWeeklyCard**, **BuyMonthlyCard**, **UpdateTariff**. Also include the following exceptional cases: **Time-Out** (i.e., traveler took too long to insert the right amount), **TransactionAborted** (i.e., traveler selected the cancel button without completing the transaction), **DistributorOutOfChange**, and **DistributorOutOfPaper**.

### Exercise 3

Draw a sequence diagram for the warehouseOnFire scenario of Figure 2-21. Include the objects **bob**, **alice**, **john**, **FRIEND**, and instances of other classes you may need. Draw only the first five message sends.

### Exercise 4

This year, the Analysis, Design, and Software Architecture course has re-introduced the group project and the entire process for accessing the exam with regards to the mandatory activities has changed. You have been tasked with drawing a UML diagram to depict the new process.
Looking at the slides from the first lecture, you have found all the information you needed to complete the task. Diligently, you have summarized all of them in the below bullet point list:

- After a student enrolls in the course, four mandatory activities (MA) require completion before being allowed to take the exam:
  - MA1 requires a student to participate to an exam simulation;
  - MA2 requires a student to submit and get approved 5 weekly;
  - MA3 requires a student to participarte to three project reviews;
  - MA4 requires a student to participarte to the project demo.
- Participation to MA1 needs to be confirmed by the teaching team.
- Each weekly activity submission needs to be verified by the teaching team.
- Participation to MA3 needs to be confirmed by the teaching team.
- Participation to MA4 needs to be confirmed by the teaching team.

Note: for the purpose of this task you must assume the following:

- The re-execution of mandatory activities must not be modelled. For instance, failing to participate to the exam simulation would require a student to take the second run of such activity. You must not model this detail.
- The number of Weekly activities can be arbitrary.
- Responsibility for the execution of activities must be modelled.
- No time constrain must be included, hence, a student could spent a lifetime completing the mandatory activities and project reviews before being accepted to the exam.

### Exercise 5

Using the solution for Exercise 4 and making use of event-based action (see below), include the process that describes:

- the teaching team sending the exam results to study administration (SAP);
- SAP registering the exams in the system;
- the students verifying their exam grade.

#### Event-based actions (from Section 7.2.1 in [1])

Event-based actions enable objects and signals to be transmitted to receiver objects. They allow you to distinguish between different types of events. You can use an **accept event action** to model an action that waits for the occurrence of a specific event. The notation element for an accept event action is a "concave pentagon"---a rectangle with a tip that points inwards from the left. If the event is a time-based event, you can use an **accept time event action**, whereby in this case, the notation is an hourglass.

To send signals, you can use **send signal actions**. Send signal actions are denoted with a "convex pentagon"---a rectangle with a tip that protrudes to the right.

![Event Based Actions](EventBasedActions.png "Event Based Actions")

[1] Seidl, Martina, Marion Scholz, Christian Huemer, and Gerti Kappel. UML@ classroom: An introduction to object-oriented modeling. Springer, 2015.

### Exercise 6

Draw a class diagram that models the following specifications:

- Each project has a name, a start date, and an end date.
- Each project is associated to a project manager, a name, a telephone, and a team.
- The project manager manages (by starting and terminating) a project and leads the team associated with the project.
- The project receives as input the requirements and produces a system. Both requirements and the system have a completion percentage and a description.
- Each team is composed by developers.

### Exercise 7

Draw a state machine diagram that models your GitHub action configuration; include all triggers that you have defined.

### Exercise 8

You are asked to design a software system to support the **Chiosco da Paolo** new fast food take away business concept.
You have had the chance to have a chat with Paolo and he told you all about the offering that the **Chiosco da Paolo** will have at the opening.  Ranting about how these italians always want options and exceptions, you try to wrap your head around a class diagram you are drawing to model all the notes you took when Paolo was presenting the food.  Among your notes:

- the place is meant to sell food. Paolo mentioned: pizza, calzone, toast, sandwitch, focacce, ...
- Paolo also mentioned that somehow he can do all the above with an assortment of ingredients, which can all be combined at the wimps of the customer.  He mentioned: ham, cheese, muchrooms, gorgonzola, spinach, speck, nutella, jam, ...
- Paolo indicated that he wants the customer to be able to say that they want double, triple, ... amount of each ingredient

Draw a class diagram representing the different types of offering that can be ordered at **Chiosco da Paolo**.

## Software Engineering (2)

### Exercise 1

Research what a Kanban board is.  Possibly starting from [here](https://www.atlassian.com/agile/kanban/boards), acquire sufficient application domain knowledge to write two as-is scenarios that represent the main usage of a physical Kanban board within a software engineering team.  Note: make sure to cite your references in the submission document.

### Exercise 2

As a design activity (i.e., before writing the code): draw a class diagram of the objects representing your analysis of the application domain related to Exercise 1.  The purpose of the diagram should be to `sketch` the main relationships between the entities and their multiplicity.  To challenge yourselves, consider that often teams use the boards to also highlight task allocation (i.e., who is responsible for/will complete/has taken a card) and that nowadays pair programming or other group practices are used to implement code.  How would you model this feature?

### Exercise 3

1. The acronym FURPS+ stands for: F_____________; U_____________; R_____________; P_____________; S_____________; +_____________.
1. The requirements engineering process is an iterative process that includes requirements ______________, ______________, and ______________.
1. Software engineering is a collection of ______________, ______________, and ______________ that help with the production of a ______________ software system developed ______________ before a ______________ while change occurs.
1. Requirements need to be complete, ______________, ______________, and ______________.
1. Important properties of requirements are realism, ______________, and ______________.
1. The output of the ______________ activity is the ______________, which include both the non-functional requirements and the functional model.

### Exercise 4

1. What level of details should UML models have?
2. What is the difference between structure diagrams and behavior diagrams in UML?  Provide two examples per category.

### Exercise 5

Consider a file system with a graphical user interface, such as Macintosh’s Finder, Microsoft’s Windows Explorer, or Linux’s KDE. The following objects were identified from a use case describing how to copy a file from a floppy disk to a hard disk: File, Icon, TrashCan, Folder, Disk, Pointer. Specify which are entity objects, which are boundary objects, and which are control (interactor) objects.

### Exercise 6

Assuming the same file system as before, consider a scenario consisting of selecting a file on a floppy, dragging it to Folder and releasing the mouse. Identify and define one control (interactor) object associated with this scenario.

### Exercise 7

Arrange the objects listed in Exercises SE.5-6 horizontally on a sequence diagram, the boundary objects to the left, then the control (interactor) object you identified, and finally, the entity objects. Draw the sequence of interactions resulting from dropping the file into a folder. For now, ignore the exceptional cases.

### Exercise 8

From the sequence diagram Figure 2-34, draw the corresponding class diagram. Hint: Start with the participating objects in the sequence diagram.

## Submitting the assignment

Ensure that your new C♯ projects are attached to your solution and all tests are running in your GitHub action for PR.

To submit the assignment you need to create a .pdf document using LaTeX containing the answers to the questions and a link to a public repository containing solution attempt.

Members of the triplets should submit the same PDF file to pass the assignments.  Make sure all group names and ID are clearly marked on the front page.  If in doubt about the name of the file, feel free to use the following standard: `<Assignement#>-<Group#>-<members initials>.pdf` (e.g., `as01-g01-emic-pate-rnei.pdf`).
