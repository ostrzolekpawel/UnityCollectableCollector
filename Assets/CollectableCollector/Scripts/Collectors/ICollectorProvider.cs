﻿namespace OsirisGames.CollectableCollector
{
    public interface ICollectorProvider<in TType, TData, TView>
    {
        void Add(TType type, ICollector<TData, TView> collector);
        void Collect(TType type, TData reward, TView view);
    }
}