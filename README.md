# 📦 Cube Quest (Unity 3D)

An interactive first-person exploration game built with Unity. Navigate through a detailed environment, enter the main building, and find the golden cube to win—but watch your step, as one wrong move leads to instant defeat.

![Unity 6](https://img.shields.io/badge/Unity-6.0_LTS-black?logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/C%23-Language-green?logo=csharp)

## 📄 About the Project
This project is a Full-Stack game prototype developed in **Unity** to demonstrate 3D physics, collision handling, and first-person mechanics. 
Unlike simple 3D projects, this version features a fully realized 3D environment where player state (victory or loss) is determined by real-time interaction with world objects.

## 📸 Visuals
To demonstrate the environment and gameplay mechanics, here are some in-game screenshots:

| Exterior View | Interior Exploration | Objective Hunt |
| :---: | :---: | :---: |
| <img src="https://github.com/ailton-santos/CubeGame/blob/main/Screenshots/Screenshot%20from%202026-02-13%2013-26-07.png" height="200"> | <img src="https://github.com/ailton-santos/CubeGame/blob/main/Screenshots/Screenshot%20from%202026-02-13%2013-30-32.png" height="200"> | <img src="https://github.com/ailton-santos/CubeGame/blob/main/Screenshots/Screenshot%20from%202026-02-13%2013-31-07.png" height="200"> |

> *Images showing the marble architecture and the challenge cubes.*

## ⚙️ Technical Features

### Player Controller (`ControleJogador.cs`)
The core movement logic resides in the `Update` loop, ensuring responsive controls:
* **Fluid Movement:** Implements WASD movement scaled by `Time.deltaTime` for frame-rate independence.
* **FPS Camera:** Mouse-based rotation with a vertical clamp at $90$ degrees to prevent unrealistic camera flipping.
* **Cursor Management:** Utilizes `Cursor.lockState` to keep the mouse centered and hidden during gameplay.

### Collision Detection (`DetectorColisao.cs`)
The game rules are managed via a dedicated collision module:
* **Dynamic Feedback:** Triggers a "YOU WIN !!" or "YOU LOSE !!" message using **TextMeshPro**.
* **Object Filtering:** Uses `col.gameObject.name.Contains` to distinguish between "Fire" hazards and "Vitoria" (Victory) objectives.
* **Game State Control:** Automatically freezes time (`Time.timeScale = 0`) and releases the cursor once a result is reached.

## Technologies Used
* **Engine:** Unity
* **Language:** C# (C-Sharp)
* **UI System:** TextMeshPro (TMP)
* **Version Control:** Git

## Getting Started
1. **Clone the repository:**
   ```bash
   git clone [https://github.com/ailton-santos/cube-quest-repo.git](https://github.com/ailton-santos/cube-quest-repo.git)
2. Open the project folder using **Unity Hub**.
3. Make sure you are using **Unity 6** or later.
4. Press **Play** in the main scene.
