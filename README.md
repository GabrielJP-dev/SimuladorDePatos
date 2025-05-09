# 🦆 Simulador de Patos — Atividade de Programação Orientada a Objetos (POO)

## 📌 Descrição da Atividade

Esta atividade prática teve como objetivo aplicar os conceitos de **herança** e **interfaces** em C# a partir da implementação de um **Simulador de Patos**. A proposta consistiu em refatorar a classe base `Duck`, separando os **comportamentos variáveis** (como voar e grasnar) em interfaces, mantendo na classe base apenas os **comportamentos comuns**.

---

## 🎯 Objetivos de Aprendizado

- Compreender e aplicar o princípio de **separação de responsabilidades**.
- Utilizar **interfaces** para representar comportamentos que podem variar entre subclasses.
- Refatorar classes utilizando **herança** e composição.
- Promover **reuso de código** e maior **flexibilidade** na manutenção.

---

## 🛠️ Tecnologias Utilizadas

- Linguagem: C#
- Paradigma: Programação Orientada a Objetos (POO)
- Ambiente: Visual Studio / VS Code

---

## 🧩 Estrutura de Classes

### 🦆 Classes de Patos
- `CyberDuck`
- `EchoWarriorDuck`
- `GodDuck`
- `KnightDuck`
- `PatoDeBorracha`
- `PatoDeCabecaVermelha`
- `PatoReal`
- `RocketDuck`
- `RubberNinjaDuck`
- `StealthDuck`

### ⚡ Interfaces de Poderes
- `IFlyer`
- `Iquack`
- `IInvisibility`
- `ILaserEyes`
- `IShieldWings`
- `ITeleport`
- `IVoar`

---

## 🧠 Respostas da Atividade

**1) Modifique seu programa Simulador de Patos retirando todos os comportamentos que variam da classe Duck e os colocando em interfaces. Continue utilizando herança da Classe Duck para o que repete (ex: display) e faça a escrita dos métodos assinados nas interfaces.**

Modifiquei o programa separando os poderes dos patos e colocando em partes diferentes. A parte que é igual em todos os patos ficou na classe principal.

**2) Explique quais os principais ganhos desta estratégia?**

A vantagem é que fica mais fácil criar novos tipos de patos e mudar os poderes deles sem bagunçar o código.

**3) Você é capaz de ver alguma desvantagem nesta estratégia?**

Uma desvantagem é que fica com muitos arquivos e pode confundir um pouco no começo.

---

✅ Projeto desenvolvido para fins educacionais.


