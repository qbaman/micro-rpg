# Micro RPG – Git Commit Recovery Log

## Context
This project (`micro-rpg`) originally contained **26 commits** that documented my development process step-by-step (from initial setup through feature implementations like Ant, Bee, Enemy, and fight mechanics).  
While using `git reset --hard` and `git push --force`, many of these commits disappeared from GitHub’s `main` branch, leaving only 2 commits visible.

---

## What Happened
- While working locally, I committed progress in GitHub Desktop.  
- In attempting to sync and “fix” the history, I ran:
  ```bash
  git reset --hard
  git push origin main --force

which rewrote history and overwrote GitHub with only part of the commit chain.

- Some commits were visible in git reflog locally, but pushing caused them to vanish from remote history.
- Multiple “recovery” branches were created (recovered-root, recovered-full, repaired-full, etc.) while trying to save earlier commits.
- Using git reflog and git log --all, I was able to locate the lost commit SHAs.
- I began rebuilding history with git cherry-pick onto a repaired-full branch.
- However, conflicts arose (example: Ant.cs, Game.cs, Bee.cs) which halted progress.

## Current Situation
- Using git reflog and git log --all, I was able to locate the lost commit SHAs.
- I began rebuilding history with git cherry-pick onto a repaired-full branch.
- However, conflicts arose (example: Ant.cs, Game.cs, Bee.cs) which halted progress.
- At this point, the repository shows a partially rebuilt history with several commits applied, but the process remains incomplete.

## Timeline of Commits (Recovered)
Here is the full sequence of commits from the reflog/log:
```bash Commit SHA	Description
6439527	feat: add starter files for Micro RPG project
7b79035	chore: add .gitignore to exclude VS temporary files
8adcc90	feat: add Ant class with basic stats and actions
c73e0b9	feat: add Ant class with fields and constructor
8198ffd	feat: add DisplayInfo method to Ant class
4fc1911	feat: add Charge and Bite actions to Ant class
acaa91e	feat: enhance Ant actions with colored output
173354e	feat: add Hades Ant and demonstrate actions in Game
a9041f3	feat: add Bee class and update Ant class structure
e426ec1	feat: add Enemy class with DisplayInfo method
2648ae8	refactor: introduce Enemy base class and update Ant to inherit
9771d90	feat: implement fight mechanics for Player and Ant
353ca73	feat: add polymorphic fight system for Player, Ant, and Bee
f6f6ae2	feat: add randomized Fight() behavior to Ant, Bee and Enemy base class
c6af6af	feat: implement polymorphic Fight() method for Ant and Bee
04b72b4	feat: add polymorphic behavior for Ant and Bee in Run loop
37d286d	refactor: introduce over Enemies list with polymorphism and type checks
794aecf	refactor: manage enemies in a list and assign items in Game
ce32361	refactor: add item support to Ant and integrate pickup in Game
9cac677	refactor: integrate LeafNinjaStar into Game
724dfcf	feat: add Item class and integrate LeafNinjaStar into Game
8acc677	feat: add Fly and Sting abilities to Bee Class
ce32361	feat: add PoisonSting to Bee class and implement Bee subclass with poison sting
9ddaa28	refactor: introduce polymorphic behavior for Player and Bee
```
## Key Issues
- Force pushes overwrote the original commit history.
- Cherry-picking commits is complicated due to merge conflicts across multiple files.
- Some commits had slightly mistyped SHAs (e.g., c73eb09 vs c73e0b9), causing “bad revision” errors.
- Time pressure means I may not be able to fully reconstruct all commits exactly in order.
