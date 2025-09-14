using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Test basic enqueue and dequeue with different priorities
    // Expected Result: Items should be dequeued in priority order (highest first)
    // Defect(s) Found: Loop condition in Dequeue() is wrong (index < _queue.Count - 1 instead of < _queue.Count).
    // Also, items are not being removed from the queue after being found.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        // Add items with different priorities
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 3);
        priorityQueue.Enqueue("Medium", 2);
        
        // Should dequeue highest priority first
        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Test FIFO behavior when multiple items have the same highest priority
    // Expected Result: When priorities are equal, first item added should be dequeued first
    // Defect(s) Found: Loop condition in Dequeue() is wrong, causing last item to be selected instead of first.
    // Also, items are not being removed from the queue after being found.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        
        // Add items with same priority in order
        priorityQueue.Enqueue("First", 2);
        priorityQueue.Enqueue("Second", 2);
        priorityQueue.Enqueue("Third", 2);
        
        // Should dequeue in FIFO order since priorities are equal
        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Test empty queue exception
    // Expected Result: Should throw InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: No defects found - this test passes correctly.
    public void TestPriorityQueue_Empty()
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
            Assert.Fail($"Unexpected exception of type {e.GetType()} caught: {e.Message}");
        }
    }

    [TestMethod]
    // Scenario: Test mixed priorities with some duplicates
    // Expected Result: Highest priority items first, then FIFO within same priority
    // Defect(s) Found: Loop condition in Dequeue() is wrong, causing wrong item selection.
    // Also, items are not being removed from the queue after being found.
    public void TestPriorityQueue_MixedPriorities()
    {
        var priorityQueue = new PriorityQueue();
        
        // Add items with mixed priorities
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);
        priorityQueue.Enqueue("D", 3); // Same priority as B
        priorityQueue.Enqueue("E", 1); // Same priority as A
        
        // Should dequeue: B (3), D (3), C (2), A (1), E (1)
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("D", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
        Assert.AreEqual("E", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Test single item
    // Expected Result: Should dequeue the single item
    // Defect(s) Found: Items are not being removed from the queue after being found, causing queue to never empty.
    public void TestPriorityQueue_SingleItem()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Only", 5);
        Assert.AreEqual("Only", priorityQueue.Dequeue());
        
        // Should be empty now
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

    [TestMethod]
    // Scenario: Test negative priorities
    // Expected Result: Higher numbers should still have higher priority
    // Defect(s) Found: Loop condition in Dequeue() is wrong (index < _queue.Count - 1 instead of < _queue.Count).
    // Also, items are not being removed from the queue after being found.
    public void TestPriorityQueue_NegativePriorities()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Low", -5);
        priorityQueue.Enqueue("High", -1);
        priorityQueue.Enqueue("Medium", -3);
        
        // Should dequeue highest priority first (least negative)
        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }
}