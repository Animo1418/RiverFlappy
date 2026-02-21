# River Flappy 🐟

A fun and engaging 2D obstacle-avoidance game built with Unity. Guide your fish through a river of obstacles and rack up the highest score!

---

## 📋 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [System Requirements](#system-requirements)
- [Installation & Setup](#installation--setup)
- [How to Play](#how-to-play)
- [Game Controls](#game-controls)
- [Project Structure](#project-structure)
- [Core Components](#core-components)
- [Technologies & Dependencies](#technologies--dependencies)
- [Project Files](#project-files)
- [Development Notes](#development-notes)
- [License](#license)

---

## 🎮 Overview

**River Flappy** is a 2D arcade-style game inspired by the popular Flappy Bird concept. Players control a fish character navigating through a river filled with obstacles. The game challenges players to survive as long as possible while earning points, testing reflexes and timing skills.

### Game Objective
- **Survive**: Navigate the fish through incoming obstacles
- **Score**: Collect points by passing through score zones
- **Challenge**: Achieve the highest possible score before colliding with obstacles

---

## ✨ Features

- 🎨 **2D Pixel Art Graphics** - Colorful sprites and animations for immersive visuals
- 🎭 **Smooth Animations** - Animated fish movement with multiple animation states
- 🎯 **Score Tracking System** - Real-time score management and game-over screen
- 🎪 **Procedural Obstacle Spawning** - Random obstacle generation with varying positions
- ⌨️ **Responsive Controls** - Support for both keyboard (Space) and mouse/touch input
- 📱 **Physics-Based Movement** - Realistic gravity and flap mechanics using 2D physics
- ⏸️ **Game State Management** - Proper pause/resume functionality with UI feedback
- 🎵 **Full Unity 6 Support** - Built with the latest Universal Render Pipeline

---

## 💻 System Requirements

### Minimum Requirements
- **OS**: Windows 10 or later, macOS 10.13+, or Linux (64-bit)
- **Unity**: Unity 6.0 (6000.0.59f2 or later)
- **RAM**: 2 GB minimum
- **Storage**: 500 MB available space
- **Display**: 1920x1080 or higher resolution

### Recommended Requirements
- **OS**: Windows 11 or macOS Monterey+
- **Unity**: Unity 6 LTS
- **RAM**: 4 GB or more
- **Storage**: 1 GB available space
- **GPU**: NVIDIA GTX 960 or equivalent

---

## 🚀 Installation & Setup

### Prerequisites
Before you begin, ensure you have the following installed:
1. **Unity Hub** - Download from [unity.com](https://unity.com/download)
2. **Unity 6.0.59f2** - Install via Unity Hub
3. **Git** - For version control (optional)

### Step 1: Clone the Repository
```bash
git clone <repository-url>
cd river-flappy
```

### Step 2: Open the Project
1. Open **Unity Hub**
2. Click **Open Project**
3. Navigate to and select the `river flappy` folder
4. Wait for the project to load and compile

### Step 3: Open the Scene
1. In the Project window, navigate to: `Assets/Scenes/`
2. Double-click `game.unity` to open the game scene
3. Press **Play** to test the game

### Step 4: Build the Game (Optional)
1. Go to **File > Build Settings**
2. Add the scene to the build
3. Select your target platform and build

---

## 🕹️ How to Play

### Game Flow
1. **Start**: Launch the game scene
2. **Control the Fish**: Use the specified controls to make the fish flap and navigate
3. **Avoid Obstacles**: Steer clear of incoming obstacles spawned at random heights
4. **Collect Points**: Pass through the score zones to increase your score
5. **Game Over**: Collision with any obstacle or the ground ends the game
6. **Restart**: Press the restart button to play again

### Gameplay Tips
- **Timing is Key**: Each flap provides an upward boost; timing is crucial for survival
- **Anticipate Spawns**: Watch for patterns in obstacle positions
- **Center Your Path**: Try to keep the fish in the middle of the safe zones
- **React Quickly**: Stay alert as obstacle frequency increases over time

---

## ⌨️ Game Controls

| Input | Action |
|-------|--------|
| **Spacebar** | Flap upward |
| **Mouse Click** | Flap upward |
| **Left Mouse Button** | Flap upward |

### UI Controls
| Button | Function |
|--------|----------|
| **Restart Button** | Restart the game after game over |
| **Main Menu** | Return to start screen (if available) |

---

## 📁 Project Structure

```
river flappy/
├── Assets/                          # Main game assets folder
│   ├── Scenes/
│   │   ├── game.unity              # Main gameplay scene
│   │   └── game.unity.meta
│   ├── script/                      # C# gameplay scripts
│   │   ├── FishController.cs        # Fish movement and collision logic
│   │   ├── FishController.cs.meta
│   │   ├── Obstacle.cs              # Obstacle behavior and destruction
│   │   ├── Obstacle.cs.meta
│   │   ├── ScoreManager.cs          # Score tracking system
│   │   ├── ScoreManager.cs.meta
│   │   ├── Spawner.cs               # Obstacle spawning system
│   │   └── Spawner.cs.meta
│   ├── sprite/                      # 2D sprites and animations
│   │   ├── 2D illustration of a.png # Fish sprite
│   │   ├── b2.png                   # Obstacle sprite
│   │   ├── end.png                  # Game over screen sprite
│   │   ├── Layer 2.png              # Background layer
│   │   ├── option.png               # Options menu sprite
│   │   ├── Fish.controller          # Fish animator controller
│   │   ├── a.anim                   # Fish animation clips
│   │   ├── FLY.anim                 # Flying animation
│   │   ├── New Animation.anim       # Additional animations
│   │   ├── Layer 1_0.controller     # Layer animation controller
│   │   └── sp1/                     # Additional sprite assets
│   ├── prefab.prefab                # Fish prefab
│   ├── InputSystem_Actions.inputactions # Input system configuration
│   ├── DefaultVolumeProfile.asset   # Volume settings asset
│   ├── UniversalRenderPipelineGlobalSettings.asset
│   └── Settings/                    # Project settings
├── ProjectSettings/                 # Unity project configuration
│   ├── ProjectVersion.txt           # Unity version (6000.0.59f2)
│   ├── AudioManager.asset           # Audio settings
│   ├── Physics2DSettings.asset      # 2D physics configuration
│   ├── ProjectSettings.asset        # General project settings
│   ├── Quality Settings.asset       # Quality/performance settings
│   ├── TagManager.asset             # Tags and layers
│   ├── TimeManager.asset            # Time settings
│   └── [other configuration files]
├── Packages/                        # Unity package dependencies
│   ├── manifest.json                # Package manifest
│   └── packages-lock.json           # Locked package versions
├── Library/                         # Unity internal library (auto-generated)
├── Logs/                            # Editor and build logs
├── Temp/                            # Temporary build files
├── UserSettings/                    # User-specific settings
├── Assembly-CSharp.csproj          # C# project file
├── river flappy.sln                # Visual Studio solution file
├── .gitignore                       # Git ignore rules
└── README.md                        # This file
```

---

## 🔧 Core Components

### FishController.cs
**Manages the player character and game mechanics**
- **Input Handling**: Detects spacebar and mouse input for flapping
- **Physics Control**: Applies upward force when the player flaps
- **Collision Detection**: Detects game-over collisions and score zones
- **Game State**: Manages alive/dead states and game pause

**Key Variables:**
- `flapStrength` (5.0) - Upward force applied when flapping
- `isAlive` - Tracks if the player is still in the game
- `panel` - Reference to game-over UI panel

### Spawner.cs
**Handles procedural obstacle generation**
- **Spawn Timing**: Creates obstacles at regular intervals
- **Random Positioning**: Places obstacles at random heights within limits
- **Spawn Rate**: Controls frequency of obstacle generation (default: 2 seconds)

**Key Variables:**
- `spawnRate` (2.0) - Seconds between obstacle spawns
- `minY` (-1.0) - Minimum spawn height
- `maxY` (3.0) - Maximum spawn height

### Obstacle.cs
**Controls individual obstacle behavior**
- **Movement**: Obstacles move toward the player
- **Destruction**: Removes obstacles when they pass the player
- **Collision**: Handled through physics collision system

### ScoreManager.cs
**Manages game scoring system**
- **Score Tracking**: Tracks and updates player score
- **Score Display**: Updates UI with current score
- **Singleton Pattern**: Ensures only one instance exists

---

## 🛠️ Technologies & Dependencies

### Core Engine
- **Unity Engine**: 6.0 (6000.0.59f2)
- **Universal Render Pipeline (URP)**: 17.0.4

### Scripting
- **C# Language**: Latest supported version
- **Namespace**: UnityEngine, UnityEngine.SceneManagement

### 2D Components
- **Unity 2D Feature**: 2.0.1
- **2D Physics**: Rigidbody2D, Collider2D components
- **Animator System**: Mecanim animation state machine

### UI & Input
- **Unity UI**: 2.0.0
- **Input System**: 1.14.2 (New Input System)
- **TextMesh Pro**: 2.0.0

### Development Tools
- **Visual Studio IDE**: 2.0.23
- **Rider IDE**: 3.0.38
- **Timeline**: 1.8.9
- **Test Framework**: 1.6.0
- **Visual Scripting**: 1.9.7

### Complete Package List
```
com.unity.collab-proxy: 2.9.3
com.unity.feature.2d: 2.0.1
com.unity.ide.rider: 3.0.38
com.unity.ide.visualstudio: 2.0.23
com.unity.inputsystem: 1.14.2
com.unity.multiplayer.center: 1.0.0
com.unity.render-pipelines.universal: 17.0.4
com.unity.test-framework: 1.6.0
com.unity.timeline: 1.8.9
com.unity.ugui: 2.0.0
com.unity.visualscripting: 1.9.7
com.unity.modules.* (AI, Animation, Audio, Physics, etc.)
```

---

## 📂 Project Files

### Assets Directory
| File/Folder | Type | Purpose |
|------------|------|---------|
| `Scenes/game.unity` | Scene | Main gameplay scene |
| `script/FishController.cs` | Script | Player control and collision |
| `script/Spawner.cs` | Script | Obstacle generation |
| `script/Obstacle.cs` | Script | Obstacle behavior |
| `script/ScoreManager.cs` | Script | Score management |
| `sprite/` | Sprites | Game graphics assets |
| `prefab.prefab` | Prefab | Reusable game objects |
| `InputSystem_Actions.inputactions` | Input Config | Input bindings |

### ProjectSettings Directory
| File | Purpose |
|------|---------|
| `ProjectVersion.txt` | Unity version info |
| `Physics2DSettings.asset` | 2D physics configuration |
| `TagManager.asset` | GameObject tags and layers |
| `QualitySettings.asset` | Performance/quality presets |
| `AudioManager.asset` | Audio system settings |
| `ProjectSettings.asset` | General project settings |

### Configuration Files
| File | Purpose |
|------|---------|
| `.gitignore` | Git repository ignore rules |
| `Assembly-CSharp.csproj` | C# project configuration |
| `river flappy.sln` | Visual Studio solution file |
| `Packages/manifest.json` | Package dependencies |

---

## 📝 Development Notes

### Key Implementation Details

#### Physics Setup
- **Gravity Scale**: Set appropriately for natural falling motion
- **Body Type**: Dynamic Rigidbody2D for player
- **Collision Detection**: Continuous for reliable obstacle detection
- **Constraints**: May lock rotation to prevent fish rotation

#### Animation System
- **Fish Animator Controller**: Controls animation states
- **Animation Clips**: Multiple clips for different fish states
  - `a.anim` - Idle/standard animation
  - `FLY.anim` - Flying/flap animation
- **State Transitions**: Triggered by game events

#### Score Zone Detection
- **Implementation**: Trigger colliders with "ScoreZone" tag
- **Method**: OnTriggerEnter2D() in FishController
- **Behavior**: Increments score when crossed

#### Game Pause Mechanism
- **Method**: Time.timeScale control (0 = paused, 1 = normal)
- **Trigger**: Game-over collision sets timeScale to 0
- **UI Display**: Game-over panel shown on collision

### Common Issues & Fixes

| Issue | Solution |
|-------|----------|
| Fish not responding to input | Check if FishController script is attached to Fish prefab |
| Obstacles not spawning | Verify Spawner script is active and obstacle prefab is assigned |
| Score not updating | Ensure ScoreManager singleton is properly initialized |
| Physics feeling off | Adjust flapStrength and gravity scale in Physics2DSettings |
| Animations not playing | Check Animator controller is assigned and state parameters match |

### Performance Optimization Tips
1. Use object pooling for frequently spawned obstacles
2. Limit maximum simultaneous obstacles on screen
3. Use sprite atlasing for reduced draw calls
4. Optimize animation clip size and complexity
5. Batch UI updates instead of per-frame changes

---

## 📋 Assets Inventory

### Sprites
- `2D illustration of a.png` - Primary fish character sprite
- `b2.png` - Obstacle sprite
- `end.png` - Game over screen sprite
- `Layer 2.png` - Background/decorative layer
- `option.png` - Options/menu sprite

### Animation Controllers
- `Fish.controller` - Main fish animator controller
- `Layer 1_0.controller` - Secondary layer controller

### Animation Clips
- `a.anim` - Main fish animation
- `FLY.anim` - Flap/flight animation
- `New Animation.anim` - Additional state animation

### Audio & Settings
- `InputSystem_Actions.inputactions` - New input system bindings
- `DefaultVolumeProfile.asset` - Volume/audio settings
- `UniversalRenderPipelineGlobalSettings.asset` - URP configuration

---

## 🔗 Related Resources

- **Unity Documentation**: [docs.unity.com](https://docs.unity.com)
- **2D Scripting**: [2D Rigidbody](https://docs.unity3d.com/Manual/class-Rigidbody2D.html)
- **Input System**: [New Input System Guide](https://docs.unity3d.com/Packages/com.unity.inputsystem@latest)
- **Physics 2D**: [Physics 2D Reference](https://docs.unity3d.com/Manual/Physics2DReference.html)

---

## 📄 License

[Add your chosen license here - e.g., MIT, Apache 2.0, GPL, or proprietary]

---

## 👤 Credits

**Project**: River Flappy  
**Engine**: Unity 6.0  
**Release Date**: [Add date if applicable]  

---

## 📞 Support & Contact

For questions, bug reports, or suggestions:
- **GitHub Issues**: [Link to issues page]
- **Email**: [Contact email if applicable]
- **Discord**: [Community server if applicable]

---

## 🎯 Future Enhancements

- [ ] Power-up system (speed boost, shield, etc.)
- [ ] Multiple difficulty levels (easy, medium, hard)
- [ ] Leaderboard system (local high scores)
- [ ] Sound effects and background music
- [ ] Additional backgrounds and themes
- [ ] Particle effect system
- [ ] Mobile optimization
- [ ] Additional fish character skins
- [ ] Combo multiplier system
- [ ] Tutorial/onboarding screen

---

## ✅ Version History

**v1.0 - Initial Release**
- Core game mechanics
- Obstacle spawning system
- Score tracking
- Game-over detection
- Input handling (keyboard and mouse)

---

*Last Updated: February 21, 2026*  
*River Flappy © 2026. All rights reserved.*
