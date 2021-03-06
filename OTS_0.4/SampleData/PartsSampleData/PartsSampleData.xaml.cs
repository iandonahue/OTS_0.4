﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.PartsSampleData
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class PartsSampleData { }
#else

	public class PartsSampleData : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public PartsSampleData()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/OTS_0.4;component/SampleData/PartsSampleData/PartsSampleData.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private Parts _Parts = new Parts();

		public Parts Parts
		{
			get
			{
				return this._Parts;
			}
		}
	}

	public class PartsItem : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Part_Name = string.Empty;

		public string Part_Name
		{
			get
			{
				return this._Part_Name;
			}

			set
			{
				if (this._Part_Name != value)
				{
					this._Part_Name = value;
					this.OnPropertyChanged("Part_Name");
				}
			}
		}

		private double _Stock_Quantity = 0;

		public double Stock_Quantity
		{
			get
			{
				return this._Stock_Quantity;
			}

			set
			{
				if (this._Stock_Quantity != value)
				{
					this._Stock_Quantity = value;
					this.OnPropertyChanged("Stock_Quantity");
				}
			}
		}

		private double _Reorder_Threshold = 0;

		public double Reorder_Threshold
		{
			get
			{
				return this._Reorder_Threshold;
			}

			set
			{
				if (this._Reorder_Threshold != value)
				{
					this._Reorder_Threshold = value;
					this.OnPropertyChanged("Reorder_Threshold");
				}
			}
		}

		private string _Manufacturer = string.Empty;

		public string Manufacturer
		{
			get
			{
				return this._Manufacturer;
			}

			set
			{
				if (this._Manufacturer != value)
				{
					this._Manufacturer = value;
					this.OnPropertyChanged("Manufacturer");
				}
			}
		}

		private double _Manufacturer_SKU = 0;

		public double Manufacturer_SKU
		{
			get
			{
				return this._Manufacturer_SKU;
			}

			set
			{
				if (this._Manufacturer_SKU != value)
				{
					this._Manufacturer_SKU = value;
					this.OnPropertyChanged("Manufacturer_SKU");
				}
			}
		}

		private string _Note = string.Empty;

		public string Note
		{
			get
			{
				return this._Note;
			}

			set
			{
				if (this._Note != value)
				{
					this._Note = value;
					this.OnPropertyChanged("Note");
				}
			}
		}
	}

	public class Parts : System.Collections.ObjectModel.ObservableCollection<PartsItem>
	{ 
	}
#endif
}
