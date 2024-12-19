using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Tasks.Themes
{
    public static class ImageButtonExtensions
    {
        // Зависимое свойство для X масштаба
        // присоединённые свойства (attached properties) для масштабирования: xScale, yScale 
        public static readonly DependencyProperty xScaleProperty =
            DependencyProperty.RegisterAttached(
                "xScale", // имя свойства
                typeof(double), // тип данных свойства 
                typeof(ImageButtonExtensions), // класс-владелец свойства (кто владеет свойством)
                new PropertyMetadata(1.0)); // значение по умолчанию

        // SetxScale: Позволяет присвоить значение свойству xScale
        // у любого объекта, который поддерживает DependencyObject
        public static void SetxScale(DependencyObject element, double value)
        {
            element.SetValue(xScaleProperty, value);
        }

        public static double GetxScale(DependencyObject element)
        {
            return (double)element.GetValue(xScaleProperty);
        }

        // Зависимое свойство для Y масштаба
        public static readonly DependencyProperty yScaleProperty =
            DependencyProperty.RegisterAttached("yScale", typeof(double), typeof(ImageButtonExtensions), new PropertyMetadata(1.0));

        public static void SetyScale(DependencyObject element, double value)
        {
            element.SetValue(yScaleProperty, value);
        }

        public static double GetyScale(DependencyObject element)
        {
            return (double)element.GetValue(yScaleProperty);
        }
    }

    public static class ScrollViewerHelper
    {
        // Цвет фона вертикального ползунка
        public static readonly DependencyProperty VerticalScrollColorProperty =
            DependencyProperty.RegisterAttached(
                "VerticalScrollColor", 
                typeof(Brush), 
                typeof(ScrollViewerHelper), 
                new PropertyMetadata(Brushes.Gray));

        public static void SetVerticalScrollColor(DependencyObject element, Brush value)
        {
            element.SetValue(VerticalScrollColorProperty, value);
        }

        public static Brush GetVerticalScrollColor(DependencyObject element)
        {
            return (Brush)element.GetValue(VerticalScrollColorProperty);
        }

        // Цвет фона горизонтального ползунка
        public static readonly DependencyProperty HorizontalScrollColorProperty =
            DependencyProperty.RegisterAttached(
                "HorizontalScrollColor", 
                typeof(Brush), 
                typeof(ScrollViewerHelper), 
                new PropertyMetadata(Brushes.Gray));

        public static void SetHorizontalScrollColor(DependencyObject element, Brush value)
        {
            element.SetValue(HorizontalScrollColorProperty, value);
        }

        public static Brush GetHorizontalScrollColor(DependencyObject element)
        {
            return (Brush)element.GetValue(HorizontalScrollColorProperty);
        }

        // Цвет ползунка вертикального скролла
        public static readonly DependencyProperty VerticalThumbColorProperty =
            DependencyProperty.RegisterAttached(
                "VerticalThumbColor", 
                typeof(Brush), 
                typeof(ScrollViewerHelper), 
                new PropertyMetadata(Brushes.DarkGray));

        public static void SetVerticalThumbColor(DependencyObject element, Brush value)
        {
            element.SetValue(VerticalThumbColorProperty, value);
        }

        public static Brush GetVerticalThumbColor(DependencyObject element)
        {
            return (Brush)element.GetValue(VerticalThumbColorProperty);
        }

        // Цвет ползунка горизонтального скролла
        public static readonly DependencyProperty HorizontalThumbColorProperty =
            DependencyProperty.RegisterAttached(
                "HorizontalThumbColor", 
                typeof(Brush), 
                typeof(ScrollViewerHelper), 
                new PropertyMetadata(Brushes.DarkGray));

        public static void SetHorizontalThumbColor(DependencyObject element, Brush value)
        {
            element.SetValue(HorizontalThumbColorProperty, value);
        }

        public static Brush GetHorizontalThumbColor(DependencyObject element)
        {
            return (Brush)element.GetValue(HorizontalThumbColorProperty);
        }
    }
}
