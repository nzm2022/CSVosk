# CSVosk


```mermaid
graph LR;
    A[Start] --> B{Is it sunny?};
    B -->|Yes| C[Go to the park];
    B -->|No| D[Stay home];
    C --> E[Play football];
    D --> F[Read a book];
    E --> G[Go home];
    F --> G;
