class Queue {
    #queue;

    constructor () {
        this.#queue = [];
    }

    enQueue(a) {
        this.#queue.push(a);
    }
    deQueue()
    {
        if (this.#queue.length != 0)
            this.#queue.shift();    
    }
    peek()
    {
        if (this.#queue.length != 0)
            return this.#queue[0];
    }
    empty()
    {
        if (this.#queue.length == 0)
            return true;
        return false;
    }
    print()
    {
        if (this.empty() == false)
        {
            console.log(this.#queue);
        }
    }
}

//main function ver JS
window.addEventListener("load", () => {
    let q = new Queue();
    let n = 1000;

    let start = performance.now();
    for (let i = 0; i < n; i++)
    {
        q.enQueue(i);
    }
    let end = performance.now();
    q.print();
    console.log("enqueue time: " + (end - start) + "ms");

    start = performance.now();
    let val = q.peek();
    end = performance.now();
    console.log("front of queue: " + val);
    console.log("peek time: " + (end - start) + "ms");

    start = performance.now();
    while (q.empty() == false)
        q.deQueue();    
    end = performance.now();
    console.log("dequeue time: " + (end - start) + "ms");
})