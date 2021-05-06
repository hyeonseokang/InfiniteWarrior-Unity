using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ParticleType
{
    Jump,
}
public class ParticleFactory : Singleton<ParticleFactory>
{
    public ParticleSystem jumpParticle;
    public ParticleSystem CreateParticle(ParticleType particleType)
    {
        ParticleSystem particle = null;
        if(particleType == ParticleType.Jump)
        {
            particle = Instantiate(jumpParticle).GetComponent<ParticleSystem>();
        }
        //Destroy(particle.gameObject, 0.8f);
        return particle;
    }
    
}
