﻿namespace CodeBase.Infrastructure.StatesMachine
{
    public interface IState : IExitable
    {
        void Enter();
    }

    public interface IPayloadState<TPayload> : IExitable
    {
        void Enter(TPayload sceneName);
    }

    public interface IExitable
    {
        void Exit();
    }
}