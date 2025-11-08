#!/usr/bin/env python3
"""
Simple agent for Enrich Maze Runner AI experiment.

This script implements a very basic agent that randomly selects actions in a grid environment.
The goal is to provide a starting point for developing more sophisticated agents.
"""

import random

class MazeEnvironment:
    def __init__(self, grid_size=(5, 5), goal=(4, 4)):
        self.grid_size = grid_size
        self.goal = goal
        self.agent_pos = (0, 0)

    def is_goal(self):
        return self.agent_pos == self.goal

    def step(self, action):
        x, y = self.agent_pos
        if action == 'up' and y > 0:
            y -= 1
        elif action == 'down' and y < self.grid_size[1] - 1:
            y += 1
        elif action == 'left' and x > 0:
            x -= 1
        elif action == 'right' and x < self.grid_size[0] - 1:
            x += 1
        self.agent_pos = (x, y)

    def reset(self):
        self.agent_pos = (0, 0)

class RandomAgent:
    def __init__(self, env):
        self.env = env
        self.actions = ['up', 'down', 'left', 'right']

    def run(self, max_steps=100):
        self.env.reset()
        for step in range(max_steps):
            if self.env.is_goal():
                print(f"Reached goal in {step} steps.")
                return
            action = random.choice(self.actions)
            self.env.step(action)
        print("Max steps reached without reaching goal.")

if __name__ == "__main__":
    env = MazeEnvironment()
    agent = RandomAgent(env)
    agent.run()
