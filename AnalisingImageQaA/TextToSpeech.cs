﻿using Microsoft.CognitiveServices.Speech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;

namespace TranslateTextFromImage;

public class TextToSpeech
{
    private readonly string subscriptionKey = "fae364ee316346abb301c21bc75c3a04";
    private readonly string region = "centralus";

    public async Task SpeakAsync(string text)
    {
        var config = SpeechConfig.FromSubscription(subscriptionKey, region);

        config.SpeechSynthesisVoiceName = "en-US-JennyNeural";


        using (var synthesizer = new SpeechSynthesizer(config))
        {
            using (var result = await synthesizer.SpeakTextAsync(text))
            {

                if (result.Reason == ResultReason.SynthesizingAudioCompleted)
                {

                }
                else
                {

              
                }
            }
        }
    }
}