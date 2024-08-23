using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neuron
{
    int prevLayerCount;
    float[] weights;
    float bias;

    public Neuron()
    { }
    

    public Neuron(int prevLayerCount)
    {
        this.prevLayerCount = prevLayerCount;
        weights = new float[prevLayerCount];
        for(int i = 0; i < prevLayerCount; i++)
        {
                weights[i] = .1f * Random.Range(-10.0f, 10.0f);
        }
        bias = .1f * Random.Range(-10.0f, 10.0f);
    }

    public Neuron(int prevLayerCount,float[] weights, float bias)
    {
        this.prevLayerCount = prevLayerCount;
        this.weights = weights;
        this.bias = bias;
    }



}


public class InputNeuron : Neuron
{
    float value;
    public InputNeuron(float value)
    {
        this.value = value;
    }
}

