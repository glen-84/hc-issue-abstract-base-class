# HC issue abstract base class

`dotnet watch --no-hot-reload`

Query:

```gql
query {
  book(where: { authorId: { eq: 20 } }) {
    id
    title
    author {
      id
      name
    }
  }
}
```

No result when there should be one.

```gql
query {
  book(where: { authorId: { eq: 2 } }) {
    id
    title
    author {
      id
      name
    }
  }
}
```

One result when there should be none (it's filtering on the book ID instead of the author ID).

---

Uncomment the code in `Author.cs`, and the filtering will work.

The filtering system is not seeing the ID in the abstract base class?