<div align="center">

# 🔢 JOGO DOS NÚMEROS

### O Clássico Puzzle de Números Deslizantes

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://docs.microsoft.com/dotnet/csharp/)
[![Windows Forms](https://img.shields.io/badge/Windows_Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)]()
[![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white)](https://visualstudio.microsoft.com/)

> Teste sua lógica e raciocínio organizando os números em ordem com o menor número de cliques possível!

</div>

---

## 📋 Sobre o Jogo

O **Jogo dos Números** é uma versão digital do clássico puzzle de números deslizantes, desenvolvido em **C# com Windows Forms**. O objetivo é organizar todos os números em ordem crescente movendo as peças para o espaço vazio, em 3 níveis de dificuldade diferentes.

> 🎓 Projeto desenvolvido como trabalho escolar no curso de Desenvolvimento de Sistemas — **2DSB 2024**.

---

## 🎮 Como Jogar

1. Selecione a **dificuldade** na tela inicial
2. As peças são **embaralhadas automaticamente**
3. Clique em uma peça **adjacente ao espaço vazio** para movê-la
4. Organize todos os números em **ordem crescente** da esquerda para a direita, de cima para baixo
5. Vença com o **menor número de cliques** possível!

---

## 🏆 Dificuldades

| Dificuldade | Grade | Peças | Espaço Vazio |
|---|---|---|---|
| 😊 **Fácil** | 4x4 | 15 números | 1 espaço |
| 😐 **Médio** | 5x5 | 24 números | 1 espaço |
| 😈 **Difícil** | 6x6 | 35 números | 1 espaço |

---

## ✨ Funcionalidades

- 🎲 **Embaralhar** — mistura as peças aleatoriamente
- 🔄 **Novo jogo** — reinicia com um novo embaralhamento
- 👁️ **Ver solução** — exibe as peças na posição correta
- 🖱️ **Contador de cliques** — acompanhe quantos movimentos você fez
- 🏠 **Voltar ao menu** — retorna à seleção de dificuldade
- 🎉 **Detecção de vitória** — mensagem ao completar o puzzle

---

## 🚀 Tecnologias Utilizadas

| Tecnologia | Função |
|---|---|
| **C#** | Linguagem principal |
| **Windows Forms** | Interface gráfica desktop |
| **Visual Studio** | IDE de desenvolvimento |

---

## 🛠️ Como Rodar o Projeto

### Pré-requisitos

- [Visual Studio](https://visualstudio.microsoft.com/) com suporte a **.NET Framework**

### 📦 Instalação

```bash
# 1. Clone o repositório
git clone https://github.com/brayanbarbosa-lab/JogoDoNumeros.git

# 2. Abra o arquivo .sln no Visual Studio
```

### ▶️ Rodando

1. Abra o projeto no **Visual Studio**
2. Pressione **F5** ou clique em **Iniciar**
3. Selecione a dificuldade e divirta-se!

---

## 📁 Estrutura do Projeto

```
JogoDoNumeros/
├── Form1.cs          # Tela inicial — seleção de dificuldade
├── facil.cs          # Modo Fácil (4x4 — 15 peças)
├── medio.cs          # Modo Médio (5x5 — 24 peças)
├── dificil.cs        # Modo Difícil (6x6 — 35 peças)
└── Program.cs        # Ponto de entrada da aplicação
```

---

## 📄 Licença

MIT License — veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

<div align="center">

Desenvolvido por **Brayan Barbosa Dos Santos** — 2DSB 2024 🔢

</div>
