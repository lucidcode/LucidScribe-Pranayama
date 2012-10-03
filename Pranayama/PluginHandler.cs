using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace lucidcode.LucidScribe.Plugin.Pranayama
{
  public class PluginHandler : lucidcode.LucidScribe.Interface.LucidPluginBase
  {

    private int m_intInhale = 8;
    private int m_intHoldIn = 32;
    private int m_intHoldOut = 0;
    private int m_intExhale = 16;

    private double m_dblValue = 100;
    private double m_dblHoldValue = 0;

    private Stage m_Stage;
    private DateTime m_dtTime;

    private enum Stage
    {
      Inhaling = 1, Exhaling = 2, HoldingIn = 3, HoldingOut = 4
    }

    public override string Name
    {
      get
      {
        return "Pranayama";
      }
    }

    public override bool Initialize()
    {
      try
      {
        return true;
      }
      catch (Exception ex)
      {
        throw (new Exception("The '" + Name + "' plugin failed to initialize: " + ex.Message));
      }
    }

    public override double Value
    {
      get
      {
        if (m_Stage == 0)
        {
          m_Stage = Stage.Inhaling;
          m_dtTime = DateTime.Now;
        }

        if (m_Stage == Stage.Inhaling)
        {
          double dblDistanceRemaining = 900 - m_dblValue;
          double dblTicksRemaining = (m_intInhale * 10) - (DateTime.Now.Subtract(m_dtTime).TotalMilliseconds / 100);
          double dblRate = dblDistanceRemaining / dblTicksRemaining;
          m_dblValue += dblRate;

          if (m_dblValue >= 900 | dblTicksRemaining < 0)
          {
            if (m_intHoldIn > 0)
            {
              m_dtTime = DateTime.Now;
              m_Stage = Stage.HoldingIn;
              m_dblValue = 900;
              m_dblHoldValue = m_dblValue;
            }
            else
            {
              m_Stage = Stage.Exhaling;
              m_dtTime = DateTime.Now;
            }
          }
        }

        if (m_Stage == Stage.HoldingIn)
        {
          double dblDistanceRemaining = m_dblHoldValue - 100;
          double dblTicksRemaining = (m_intHoldIn * 10) - (DateTime.Now.Subtract(m_dtTime).TotalMilliseconds / 100);
          double dblRate = dblDistanceRemaining / dblTicksRemaining;
          m_dblHoldValue -= dblRate;

          if (m_dblHoldValue <= 100 | dblTicksRemaining < 0)
          {
            m_Stage = Stage.Exhaling;
            m_dtTime = DateTime.Now;
          }
        }

        if (m_Stage == Stage.Exhaling)
        {
          double dblDistanceRemaining = m_dblValue - 100;
          double dblTicksRemaining = (m_intExhale * 10) - (DateTime.Now.Subtract(m_dtTime).TotalMilliseconds / 100);
          double dblRate = dblDistanceRemaining / dblTicksRemaining;
          m_dblValue -= dblRate;

          if (m_dblValue <= 100 | dblTicksRemaining < 0)
          {
            m_dtTime = DateTime.Now;
            if (m_intHoldOut > 0)
            {
              m_dblValue = 100;
              m_Stage = Stage.HoldingOut;
              m_dblHoldValue = m_dblValue;
            }
            else
            {
              m_Stage = Stage.Inhaling;
            }
          }
        }

        if (m_Stage == Stage.HoldingOut)
        {
          double dblDistanceRemaining = m_dblHoldValue - 100;
          double dblTicksRemaining = (m_intHoldIn * 10) - (DateTime.Now.Subtract(m_dtTime).TotalMilliseconds / 100);
          double dblRate = dblDistanceRemaining / dblTicksRemaining;
          m_dblHoldValue -= dblRate;

          if (m_dblHoldValue >= 100 | dblTicksRemaining < 0)
          {
            m_Stage = Stage.Inhaling;
            m_dtTime = DateTime.Now;
          }
        }

        if (m_dblValue > 999)
        {
          m_dblValue = 999;
        }
        if (m_dblValue < 0)
        {
          m_dblValue = 0;
        }
        return m_dblValue;
      }
    }
  }
}
