class Solution:
    def score(operations:list[str]) -> int:
        score = []
        index = 0

        for operation in operations:
            if operation.isdigit():
                score.append(int(operation))
                index += 1
            elif operation == "+":
                score.append(score[index - 1] + score[index - 2])
                index += 1
            elif operation == "C":
                score.pop()
                index -= 1
            elif operation == "D":
                score.append(2 * score[index - 1])
                index += 1
            else:
                negative_number = -int(operation.strip())
                score.append(-negative_number)
                index += 1

        return sum(score)

ops = ["5","2","C","D","+"]
print("Example 1:")
print(Solution.score(ops))

ops2 = ["5","-2","4","C","D","9","+","+"]
print("Example 2:")
print(Solution.score(ops2))

ops3 = ["1","C"]
print("Example 3:")
print(Solution.score(ops3))