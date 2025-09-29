# Micro RPG – Git Commit Recovery Log

## Context
This project (`micro-rpg`) originally contained **26 commits** that documented my development process step-by-step (from initial setup through feature implementations like Ant, Bee, Enemy, and fight mechanics).  
Due to mistakes while using `git reset --hard` and `git push --force`, many of these commits disappeared from GitHub’s `main` branch, leaving only 2 commits visible.

---

## What Happened
- While working locally, I committed progress correctly in GitHub Desktop.  
- I **did not push regularly**, meaning GitHub only had an outdated view of the repository.  
- In attempting to sync and “fix” the history, I ran:
  ```bash
  git reset --hard
  git push origin main --force
