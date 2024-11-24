# LeetcodeDotNet

### Generative AI Disclosure
No generative AI was used in this project with the exception of altering Leetcode testcase data to conform to what was needed. For example, the testcase that can be copied for the sudoku validity problem looks like this:

```
[["5","3",".",".","7",".",".",".","."],
["6",".",".","1","9","5",".",".","."],
[".","9","8",".",".",".",".","6","."],
["8",".",".",".","6",".",".",".","3"],
["4",".",".","8",".","3",".",".","1"],
["7",".",".",".","2",".",".",".","6"],
[".","6",".",".",".",".","2","8","."],
[".",".",".","4","1","9",".",".","5"],
[".",".",".",".","8",".",".","7","9"]]
```

However, that's not what's needed; we want an array of char arrays. A perfect task for an LLM, which gave me this:

```
['5', '3', '.', '.', '7', '.', '.', '.', '.'],
['6', '.', '.', '1', '9', '5', '.', '.', '.'],
['.', '9', '8', '.', '.', '.', '.', '6', '.'],
['8', '.', '.', '.', '6', '.', '.', '.', '3'],
['4', '.', '.', '8', '.', '3', '.', '.', '1'],
['7', '.', '.', '.', '2', '.', '.', '.', '6'],
['.', '6', '.', '.', '.', '.', '2', '8', '.'],
['.', '.', '.', '4', '1', '9', '.', '.', '5'],
['.', '.', '.', '.', '8', '.', '.', '7', '9']
```

Just had to pop on one more set of brackets, and I was good to go.