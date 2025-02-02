# EXAM FOR WEEK 6

## KEEP IN MIND: YOU ARE DOING THIS FOR YOUR BRIGHT FUTURE, SO GIVE YOUR 120%!
## ПОМНИТЕ: ВЫ ДЕЛАЕТЕ ЭТО ДЛЯ СВОЕГО СВЕТЛОГО БУДУЩЕГО, ПОЭТОМУ ВЫКЛАДЫВАЙТЕСЬ НА ВСЕ СВОИ 120%!

## RULES:
> No interner, no help to each other!

> Make one folder and place all your work there (e.g. my_third_exam)

> Send the folder to the github 

> You have 2 hours only


### Task 1 
Print the following pattern.(Распечатайте следующий шаблон.) \
1 \
2 2 \
3 3 3 \
4 4 4 4 \
5 5 5 5 5 \
6 6 6 6 \
7 7 7 \
8 8 \
9 


### Task 2 Ice Cream
Create a function which takes a list of objects from the class IceCream and returns the sweetness value of the sweetest ice cream. Note that there is a class provided for you in the Tests tab.
Each sprinkle has a sweetness value of 1
Check below for the sweetness values of the different flavors.
Создайте функцию, которая берет список объектов класса IceCream и возвращает значение сладости самого сладкого мороженого. Обратите внимание, что на вкладке «Тесты» вам предоставлен класс.
Каждая посыпка имеет показатель сладости 1.
Ниже приведены значения сладости различных вкусов.
 
  class IceCream:
          def __init__(self, flavor, num_sprinkles):
              self.flavor = flavor
              self.num_sprinkles = num_sprinkles

 Flavors	        |Sweetness Value    |
 -------------------|-------------------|
 Plain	            |   0               |
 Vanilla	        |   5               |
 ChocolateChip	    |   5               |
 Strawberry         |   10              |
 Chocolate	        |   10              |   
 ---------------------------------------|
 
ice1 = IceCream("Chocolate", 13)         # value of 23
ice2 = IceCream("Vanilla", 0)           # value of 5

sweetest_icecream([ice1, ice2, ice3, ice4, ice5]) ➞ 23
sweetest_icecream([ice3, ice1]) ➞ 23




# Task 3: User Management System

## Description

You need to create a User Management System using **C# Class Library** for business logic and a **Console Application** for interaction with the user.

### Requirements:

1. **Create a Solution** `UserManagementSolution` which includes:
   - `UserLibrary` (Class Library) — for business logic.
   - `UserApp` (Console Application) — for user interaction.
2. **Create the `User` class**, which contains:
   - A unique identifier.
   - User name.
   - Email.
   - User role (Administrator, Moderator, Regular user).
   - Method `DisplayInfo()`, which displays user information.

## Part 1: Basic Classes and Structures

3. **Create `Role` class** which contains:
   - Role name.
   - Permissions.
   - Method `GetPermissions()` which returns a list of permissions.
4. **Add `UserManager` class** which:
   - Manages a list of users.
   - Allows adding and removing users.
   - Allows changing roles of users.

## Part 2: Encapsulation and Data Handling

5. **Implement Encapsulation**:
   - Use **access modifiers** to protect data.
   - Add **properties (`get` / `set`)** with email validation.
6. **Add Role management**, allowing users to have roles that define their permissions.

## Part 3: Inheritance and Polymorphism

7. **Create two subclasses `AdminUser` and `RegularUser`** from `User`:
   - `AdminUser` can manage users and assign roles.
   - `RegularUser` can only view information.
8. **Implement Polymorphism** by overriding the `DisplayInfo()` method in both `AdminUser` and `RegularUser`.

## Part 4: Interfaces and Business Logic

9. **Create `IUserActions` interface** with methods:
   - `CreateUser()`.
   - `DeleteUser()`.
   - `ChangeRole()`.
10. **Implement the interface in `UserManager`** to manage users via a unified contract.

## Part 5: Console Application and File Handling

11. **Set up the `UserApp`** so that the user can:
   - Add and remove users.
   - Change user roles.
   - Display a list of users and their permissions.


### Expected Outcome:
A fully functional **Console-based User Management System** utilizing **OOP principles such as Encapsulation, Inheritance, Polymorphism, and Interfaces**.
