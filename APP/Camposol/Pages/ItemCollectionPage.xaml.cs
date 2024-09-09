﻿using Camposol.ViewModels;

namespace Camposol.Pages;

/// <summary>
/// Entry form UI
/// </summary>
public partial class ItemCollectionPage
{

	/// <summary>
	/// Receives the depedencies by DI
	/// </summary>
	public ItemCollectionPage(ItemCollectionViewModel viewModel) : base(viewModel, "Collection")
	{
		InitializeComponent();
	}
}

