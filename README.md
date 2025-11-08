# Enrich Maze Runner AI Experiment

## Goals
- Implement a simple AI agent navigating a maze-like environment reminiscent of Maze Runner with enriched features.
- Test the agent's ability to find optimal paths and collect rewards while avoiding obstacles.
- Provide a foundation for future enhancements like reinforcement learning and increasing environment complexity.

## Data Flow
1. The environment generates a maze with start and end points plus optional collectible items or obstacles.
2. The agent receives observations about its current position and neighbouring cells.
3. Based on observations, the agent decides an action (move up, down, left, right).
4. The environment updates the state based on the action and returns a new observation and reward.
5. The loop continues until the agent reaches the goal or the maximum number of steps is reached.

## How to Run
1. Clone this repository.
2. Ensure Python 3.8+ is installed.
3. Install dependencies if any (currently none).
4. Run the starter script:
   ```
   python simple_agent.py
   ```
   This will run a basic agent in a generated maze and print the steps taken.
