using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace lucidcode.LucidScribe.Plugin.Pranayama
{
  public class PluginHandler : lucidcode.LucidScribe.Interface.LucidPluginBase
  {

    ExerciseForm exerciseForm = new ExerciseForm();
    private double m_intInhale = 8;
    private double m_intHoldIn = 32;
    private double m_intHoldOut = 0;
    private double m_intExhale = 16;
    private int m_intCapacity = 900;

    private string SelectedExercise;

    private int m_intRepeat = -1;
    private int Cycle = 0;

    private double m_dblValue = 100;
    private double m_dblHoldValue = 0;

    private Stage m_Stage;
    private DateTime m_dtTime;

    private enum Stage
    {
      Inhaling = 1, Exhaling = 2, HoldingIn = 3, HoldingOut = 4, Complete = 5
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
        exerciseForm.ExerciseChanged += exerciseForm_ExerciseChanged;
        exerciseForm.ShowDialog();
        
        return true;
      }
      catch (Exception ex)
      {
        throw (new Exception("The '" + Name + "' plugin failed to initialize: " + ex.Message));
      }
    }

    void exerciseForm_ExerciseChanged(string Exercise)
    {
      if (SelectedExercise == Exercise)
      {
        return;
      }

      SelectedExercise = Exercise;

      if (SelectedExercise == "8:32:16")
      {
        m_intInhale = 8;
        m_intHoldIn = 32;
        m_intHoldOut = 0;
        m_intExhale = 16;
        m_intRepeat = -1;
        m_intCapacity = 900;
      }
      else if (SelectedExercise == "Kapalbhati")
      {
        // Warm up first
        m_intInhale = 7;
        m_intHoldIn = 0;
        m_intHoldOut = 0;
        m_intExhale = 7;
        m_intRepeat = 4;
        m_intCapacity = 900;
      }
      else if (SelectedExercise == "Bhastrika - Ujjayi")
      {
        // Warm up first
        m_intInhale = 7;
        m_intHoldIn = 0;
        m_intHoldOut = 0;
        m_intExhale = 7;
        m_intRepeat = 4;
        m_intCapacity = 900;
      }
      else if (SelectedExercise == "Heart Breath")
      {
        m_intInhale = 7;
        m_intHoldIn = 0;
        m_intHoldOut = 0;
        m_intExhale = 7;
        m_intRepeat = -1;
        m_intCapacity = 900;
      }

      m_Stage = Stage.Inhaling;
      m_dtTime = DateTime.Now;
      m_dblValue = 0;
    }

    public override System.Windows.Forms.Control SettingsPanel
    {
      get
      {
        return exerciseForm.settingsControl;
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
          double dblDistanceRemaining = m_intCapacity - m_dblValue;
          double dblTicksRemaining = (m_intInhale * 10) - (DateTime.Now.Subtract(m_dtTime).TotalMilliseconds / 100);
          double dblRate = dblDistanceRemaining / dblTicksRemaining;
          m_dblValue += dblRate;

          if (m_dblValue >= m_intCapacity | dblTicksRemaining < 0)
          {
            if (m_intHoldIn > 0)
            {
              m_dtTime = DateTime.Now;
              m_Stage = Stage.HoldingIn;
              m_dblValue = m_intCapacity;
              m_dblHoldValue = m_dblValue;
            }
            else
            {
              m_Stage = Stage.Exhaling;
              m_dtTime = DateTime.Now;
            }
            Cycle++;
            if (m_intRepeat > 0 & Cycle >= m_intRepeat)
            {
              if (SelectedExercise == "Kapalbhati")
              {
                SelectedExercise = "";
                Cycle = 0;
                m_intInhale = 0.5;
                m_intHoldIn = 0;
                m_intHoldOut = 0;
                m_intExhale = 0.5;
                m_intRepeat = 81;
                m_intCapacity = 300;
              }
              else if (SelectedExercise == "Bhastrika - Ujjayi")
              {
                  SelectedExercise = "Bhastrika";
                  Cycle = 0;
                  m_intInhale = 2;
                  m_intHoldIn = 0;
                  m_intHoldOut = 0;
                  m_intExhale = 2;
                  m_intRepeat = 8;
                  m_intCapacity = 900;
              }
              else if (SelectedExercise == "Bhastrika")
              {
                  SelectedExercise = "";
                  Cycle = 0;
                  m_intInhale = 4;
                  m_intHoldIn = 0;
                  m_intHoldOut = 0;
                  m_intExhale = 8;
                  m_intRepeat = 8;
                  m_intCapacity = 900;
              }
              else
              {
                m_intInhale = 7;
                m_intHoldIn = 0;
                m_intHoldOut = 0;
                m_intExhale = 7;
                m_intRepeat = -1;
                m_intCapacity = 900;
              }
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
