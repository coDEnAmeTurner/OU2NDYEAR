
//Time Complex: O(n + k)
function countingSort(list, n)
{
	if (n == 0 || n == 1)
		return;
	let tmpn = 0; 
	//step 1:
	//decide the size k of tmp by going through each entry of a, if the entry > current tmpn (currently 0), 
	//assign entry to tmpn
	for (let i = 0; i < n; i++)
	{
		if (list[i] + 2 > tmpn)
			tmpn = list[i] + 2;
	}
	let tmp = new Array(tmpn);
	for (let i = 0; i < tmpn; i++)
	{
		tmp[i] = 0;
	}
	//for each entry in a, increment its corresponding entry in tmp where a's entry is tmp's index
	for (let i = 0; i < n; i++)
	{
		tmp[list[i]]++;
	}

	//step 2:
	//do addition: tmp[i] = tmp[i] + tmp[i - 1], where 1 <= i <= tmpn - 1
	for (let i = 1; i < tmpn; i++)
	{
		tmp[i] += tmp[i - 1];
	}

	//step 3:
	//add sorted values to sorted array based on current tmp
    let sorted = new Array(n);
	for (let i = n - 1; i >= 0; i--)
	{
		tmp[list[i]]--;
		sorted[tmp[list[i]]] = list[i];
	}
	return sorted;
}

window.addEventListener("load", () => {
    let a = [];
    const n = 1000;
    for (let i = 0; i < n; i++)
    {
        a.push(Math.floor(Math.random() * 100));
    }
	console.log(a);

    let start = performance.now();
    console.log(countingSort(a, n));
    let end = performance.now();
    let duration = (end - start).toFixed(2);
    console.log(duration + "ms");
})