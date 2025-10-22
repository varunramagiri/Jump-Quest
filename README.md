# 🎮 Jump-Quest (Unity 2D Game)

A retro-style **2D platformer** created in **Unity (C#)**.  
Players jump across platforms, collect coins, and avoid enemies to reach the goal.  
Inspired by the charm of *Super Mario Bros*, this project focuses on physics, collision detection, and level design.

---

## ✨ Features
- 🕹️ Classic side-scrolling platformer gameplay  
- 💰 Collectible coins with score tracking  
- ⚡ Smooth physics-based jumping and collisions  
- 🎨 Multiple levels with background music and sprites  
- 💀 Simple enemy AI and hazards  
- 🧱 Custom tile-based level design  
- 🎮 Keyboard controls for movement and jumping  

---

## 🧰 Tech Stack
| Category        | Tools / Frameworks      |
|-----------------|-------------------------|
| **Engine**      | Unity 2022 LTS (2D template) |
| **Language**    | C#                      |
| **Physics**     | Unity Rigidbody2D & Colliders |
| **Art / Audio** | Custom / free sprite assets |
| **IDE**         | Visual Studio Code / Rider |

---

## 🗂️ Project Structure
JumpQuest/
├── Assets/
│ ├── Scripts/
│ │ ├── PlayerController.cs # Player movement & jump logic
│ │ ├── EnemyController.cs # Simple AI for enemies
│ │ ├── CoinPickup.cs # Score update on collection
│ │ ├── GameManager.cs # Scene management & score handling
│ │ └── UIManager.cs # UI elements (score, lives)
│ ├── Scenes/
│ │ ├── MainMenu.unity
│ │ ├── Level1.unity
│ │ └── GameOver.unity
│ ├── Prefabs/ # Reusable objects (player, enemies, coins)
│ ├── Sprites/ # 2D artwork & tiles
│ ├── Audio/ # Background music & sound effects
│ └── UI/ # Menus and HUD
├── ProjectSettings/
├── Packages/
└── README.md
