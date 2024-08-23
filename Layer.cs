using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LayerType{INPUT, HIDDEN, OUTPUT};

public class Layer 
{
    public LayerType layerType;

    int neuronCount;
    Neuron[] neurons;
    public float[] values;

    Layer(int neuronCount)
    {
        this.neuronCount = neuronCount;
        if (layerType == LayerType.INPUT)
        {
            for (int i = 0; i < neuronCount; i++) {
                neurons[i] = new InputNeuron(values[i]);
            }
        }
        else
        {
            for (int i = 0; i < neuronCount; i++)
            {
                neurons[i] = new Neuron(neuronCount);
            }
        }
    }
}
