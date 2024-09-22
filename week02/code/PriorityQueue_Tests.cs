using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue two items with different priorities, dequeue one item.
    // Expected Result: The item with the highest priority should be dequeued.
    // Defect(s) Found: The dequeue operation did not remove the item with the highest priority.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item 1", 2);
        priorityQueue.Enqueue("Item 2", 1);
        
        var dequeuedItem = priorityQueue.Dequeue();

        Assert.AreEqual("Item 1", dequeuedItem); // Item 1 has the higher priority
    }

    [TestMethod]
    // Scenario: Enqueue three items with the same highest priority, dequeue one item.
    // Expected Result: The item added first among those with the highest priority should be dequeued.
    // Defect(s) Found: The dequeue operation did not remove the first item added with the highest priority.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item 3", 3);
        priorityQueue.Enqueue("Item 4", 3);
        priorityQueue.Enqueue("Item 5", 3);
        
        var dequeuedItem = priorityQueue.Dequeue();

        Assert.AreEqual("Item 3", dequeuedItem); // Item 3 should be dequeued first
    }

    [TestMethod]
    // Scenario: Dequeue an item from an empty queue.
    // Expected Result: An InvalidOperationException should be thrown.
    // Defect(s) Found: Dequeue operation unexpectedly succeeded on an empty queue.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}