﻿using System;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;

public struct CarSpeedComponent : IComponentData
{
    public float NormalizedSpeed;
    public float SplineTimer;
}

public struct SplineDataComponent : IComponentData
{
    public CubicBezier Bezier;
    public TrackGeometry Geometry;
    public float Length;
    public byte TwistMode;
}

public struct OnSplineComponent : IComponentData
{
    public ushort Spline;
    public sbyte Side;
    public sbyte Direction;
}

public struct LocalIntersectionComponent : IComponentData
{
    public CubicBezier Bezier;
    public TrackGeometry Geometry;
    public float Length;
    public ushort Intersection;
    public sbyte Side;
}

public struct InIntersectionComponent : IComponentData
{
    public bool Value;
}

public struct CoordinateSystemComponent : IComponentData
{
    public float3 Position;
    public float3 Up;
    public float3 Forward;
}

[Serializable]
[MaterialProperty("_Color", MaterialPropertyFormat.Float4)]
public struct CarColor : IComponentData
{
    public float4 Value;
}