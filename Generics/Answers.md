
# Generics — Answers

## Step 2 — A Store for Courses

Both stores have the same methods for adding, finding, retrieving, and removing items. They differ in the types they store: Student has a Name, while Course has a Title and Price.

## Step 3 — One Generic Class

**Compiler error:**

CS1061: 'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found.

**Explanation:**

The compiler cannot guarantee that T has an Id property because T can represent any type. A generic constraint is needed to specify which types are supported.

## Step 7 — Prove It in Main

The program tests student and course stores, retrieves items by ID, catches a duplicate ID exception, prints page 2 of the students, and finds a course in a regular List<Course>.

`Store<string>()` must not compile because Store<T> requires T to implement IHasId, and string does not implement that interface.

## Final Question — Common Name

This type of reusable class is commonly called a generic repository.
