// Good practice with collections
// Let’s say you need to create a method to process a collection. For maximum flexibility, you could
// declare the input parameter to be IEnumerable<T> and make the method generic, as shown in the
// following code:

void ProcessCollection<T>(IEnumerable<T> collection)
{
 // process the items in the collection,
 // perhaps using a foreach statement
}

// I could pass an array, a list, a queue, or a stack, containing any type like int or string or Person, or
// anything else that implements IEnumerable<T>, into this method and it will process the items. However,
// the flexibility to pass any collection to this method comes at a performance cost.
// One of the performance problems with IEnumerable<T> is also one of its benefits: deferred execution,
// also known as lazy loading. Types that implement this interface do not have to implement deferred
// execution, but many do.
// But the worst performance problem with IEnumerable<T> is that the iteration must allocate an object
// on the heap. To avoid this memory allocation, you should define your method using a concrete type,
// as shown highlighted in the following code:

void ProcessCollection<T>(List<T> collection)
{
 // process the items in the collection,
 // perhaps using a foreach statement
}

// This will use the List<T>.Enumerator GetEnumerator() method, which returns a struct, instead of
// the IEnumerator<T> GetEnumerator() method, which returns a reference type. Your code will be two to
// three times faster and require less memory. As with all recommendations related to performance, you
// should confirm the benefit by running performance tests on your actual code in a product environment


// two ways to define the same index, 3 in from the start
Index i1 = new(value: 3); // counts from the start
Index i2 = 3; // using implicit int conversion operator
// two ways to define the same index, 5 in from the end
Index i3 = new(value: 5, fromEnd: true);
Index i4 = ^5; // using the caret operator