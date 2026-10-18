# Part 03 — answers

---

## BlockedUsers

- Time complexity before: O(B × R), where B is the number of blocked IDs and R is the number of requests.
- Time (ms) before: 11 ms
- What did you change?
  I converted the blocked IDs into a HashSet<int> to avoid scanning a List<int> for every request.
- Time complexity after: O(B + R) expected, including building the HashSet and checking all requests.
- Time (ms) after: 1 ms

---

## Students

- What was the problem?
  GetAllStudents created one million Student objects and stored them in a list, even though the program printed only the first three students.

- What did you change?
  I changed GetAllStudents to return IEnumerable<Student> and used yield return to generate students lazily. Only the students requested by the caller are created.