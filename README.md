# CodeKata-Mak-A-Spiral
https://www.codewars.com/kata/534e01fbbb17187c7e0000c6/solutions/csharp

Your task, is to create a NxN spiral with a given size.

For example, spiral with size 5 should look like this:
<pre>
1   1   1   1   1

0   0   0   0   1

1   1   1   0   1

1   0   0   0   1

1   1   1   1   1
</pre>
and with the size 10:
<pre>
1   1   1   1   1   1   1   1   1   1

0   0   0   0   0   0   0   0   0   1

1   1   1   1   1   1   1   1   0   1

1   0   0   0   0   0   0   1   0   1

1   0   1   1   1   1   0   1   0   1

1   0   1   0   0   1   0   1   0   1

1   0   1   0   0   0   0   1   0   1

1   0   1   1   1   1   1   1   0   1

1   0   0   0   0   0   0   0   0   1

1   1   1   1   1   1   1   1   1   1
</pre>

Return value should contain array of arrays, of 0 and 1, with the first row being composed of 1s. For example for given size 5 result should be:
<pre>
[
    [1,1,1,1,1],
    [0,0,0,0,1],
    [1,1,1,0,1],
    [1,0,0,0,1],
    [1,1,1,1,1]
]
</pre>

Because of the edge-cases for tiny spirals, the size will be at least 5.

General rule-of-a-thumb is, that the snake made with '1' cannot touch to itself.
