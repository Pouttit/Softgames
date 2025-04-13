# 🎮 Softgames Unity Demo

A Unity project showcasing:
- 🃏 A dynamic card stack system
- 🔥 A fire particle effect with UI toggle
- 💬 A dialogue system using inline text + emojis

---

## 🃏 Card Stack System

**Features:**
- Instantiates 144 cards stacked like a deck.
- Each card overlaps the previous slightly.
- Every 1 second, the top card moves to another stack with a smooth 2-second animation.
- Animation stops after 114 moves.
- Random sprite is chosen per card on instantiation.

## 💬 Dialogue System with Emojis

**Features:**
- Displays a series of dialogue lines from characters.
- Supports inline emoji rendering using Unity’s `<sprite name="...">` system.
- Avatars shown using sprite images per character.

## 🔥 Fire Particle Effect

**Features:**
- Realistic fire particle system.
- Controlled using a UI Button.
- Animator Controller toggles fire effect on/off via state machine.
