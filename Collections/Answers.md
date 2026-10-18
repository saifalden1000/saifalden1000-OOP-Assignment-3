
# Collections & Extension Methods — Answers

## Task 2.1 — Research

- **IReadOnlyDictionary:** Provides read-only access to key-value pairs. Unlike Dictionary, its interface doesn't expose methods to add, update, or remove entries.
- **SortedDictionary:** Keeps keys sorted and supports lookups in O(log n), while Dictionary provides average O(1) lookups without guaranteed sorted enumeration.
- **When to use SortedDictionary:** When entries must always be enumerated in key order, such as a timetable.

### Sources
- Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2
- Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.sorteddictionary-2

---

## Task 2.2 — Pick the Collection

- **S1 — Dictionary:** Fast lookups by student national ID.
- **S2 — HashSet:** Prevents duplicate course tags.
- **S3 — List:** Preserves grade order and allows duplicates.
- **S4 — IReadOnlyDictionary:** Allows reading prices without exposing modification methods.
- **S5 — SortedDictionary:** Keeps sessions sorted by start time.
- **S6 — IEnumerable:** Allows iteration to stop early without requiring all results to be stored first.
