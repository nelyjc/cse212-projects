using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue several people with different priorities and then dequeue them to ensure they come out in the correct order.
    /// Then dequeue all people and check that the order is correct based on priority (highest priority first, and if priorities are the same, then in the order they were added).
    /// 
    // Expected Result: Items with the higherst priority should be dequeued first.
    //  If two items have the same priority, they should be dequeued in the order they were enqueued.
    // First, Third, Fourth, Second
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Alice", 2);
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Charlie", 3);
        priorityQueue.Enqueue("Diana", 2);

        Assert.AreEqual("Charlie", priorityQueue.Dequeue());
        Assert.AreEqual("Alice", priorityQueue.Dequeue());
        Assert.AreEqual("Diana", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: If the queue is empty and Dequeue is called, an exception should be thrown.
    // Expected Result: An InvalidOperationException should be thrown.
    // Defect(s) Found: 
       public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                string.Format("Unexpected exception of type {0} caught: {1}",
                    e.GetType(), e.Message)
            );
        }
    }
    // Add more test cases as needed below.
}