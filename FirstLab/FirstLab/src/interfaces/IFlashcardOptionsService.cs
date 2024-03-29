﻿using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Markup;
using FirstLab.src.models;
using FirstLab.src.utilities;

namespace FirstLab.src.interfaces;

public interface IFlashcardOptionsService
{
    Task RemoveFlashcardSet(FlashcardSet selectedSet, ObservableCollection<FlashcardSet> flashcardSets);

    Task<ObservableCollection<FlashcardSet>> InitializeFlashcardSets();

    ObservableCollection<FlashcardSet> CalculateFlashcardSetDifficulties(ObservableCollection<FlashcardSet> flashcardSets);

    string CalculateDifficultyOfFlashcardSet(FlashcardSet flashcardSet);

    void GoToFlashcardCustomization(FlashcardSet? flashcardSet = null);

    void LaunchPlayWindow(FlashcardSet flashcardSet);

    void FilterFlashcardSets(string searchString, ObservableCollection<FlashcardSet> flashcardSets, ObservableCollection<FlashcardSet> filteredFlashcardSets);
}