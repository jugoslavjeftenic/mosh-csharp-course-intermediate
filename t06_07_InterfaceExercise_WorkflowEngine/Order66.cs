﻿namespace t06_07_InterfaceExercise_WorkflowEngine
{
    public class Order66 : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Executing order 66!");
        }
    }
}