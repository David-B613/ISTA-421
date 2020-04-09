### Homework Chapter 19
### David Babers
### ISTA 421: Developing Cloud Applications
### March 23, 2020

1.	What is an enumerable collection?

* **A collection that implements the System.Collection.IEnumberable Interface.**

2.	What properties and methods does the IEnumerable interface contain?

* **IT contains the single method called GetEnumerator.**

3.	What properties and methods does the IEnumerator interface contain?

* **This is a repeated question.**

4.	What values does the MoveNext() method return? What does it do?

* **It returns a true of false boolean. It moves through the list returning the next value in the que until there is nothing left to return.**

5.	What values does the Reset() method return? What does it do?

* **It returns back to the item before the first. But it does not return back a value.**

6.	Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type safety?

* **No it is not, you will do this by using generics.**

7.	Why don’t recursive methods retain state when used with data structures like binary trees?

* **A new stack.**

8.	How do you define an enumerator?

* **It is a reference point to know where you are in a collection.**

9.	What is an iterator?

* **It is a method, that remembers the current location and next iteration.**

10.	 10. What does yield do?

* **indicate that the method or a get accessor in which it has been used is an iterator**
