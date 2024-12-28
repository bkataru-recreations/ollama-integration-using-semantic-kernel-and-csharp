# ollama-integration-using-semantic-kernel-and-csharp

following [Ollama Integration Using Semantic Kernel and C#: A Step-by-Step Guide](https://mehmetozkaya.medium.com/ollama-integration-using-semantic-kernel-and-c-a-step-by-step-guide-311b7d163b67)

## setup

install ollama

```bash
$ curl -fsSL https://ollama.com/install.sh | sh
```

pull `llama3.2:3b` and spin up the inference server

```bash
$ ollama pull llama3.2
$ ollama serve
```

## todo

- [ ] containerize development environment using devcontainers
    - [ ] install .NET 9 and its relevant VSCode extensions as part of devcontainer build process
    - [ ] automate installing ollama, fetching the model, and running the inference server