using Tensorflow;
using Tensorflow.Keras.Engine;
using static Tensorflow.Binding;
using static Tensorflow.KerasApi;

namespace Birga
{
    /// <summary>
    /// Model
    /// </summary>
    internal class Model
    {
        IModel _model;
        int numEpochs = 50;
        int batchSize = 32;

        public void CreateModelCNN(int points_count)
        {
            try
            {
                // Визначення параметрів моделі
                int timeSteps = points_count; // Кількість часових кроків
                int features = 6;

                // Створення моделі Conv1D
                var input = tf.keras.layers.Input(new Shape(timeSteps, features));
                var conv1D = tf.keras.layers.Conv1D(points_count, kernel_size: 3, activation: "relu").Apply(input);
                var maxPooling1D = tf.keras.layers.MaxPooling1D(pool_size: 2).Apply(conv1D);
                var flatten = tf.keras.layers.Flatten().Apply(maxPooling1D);
                var dense = tf.keras.layers.Dense(units: 50, activation: "relu").Apply(flatten);
                var output = tf.keras.layers.Dense(units: 1).Apply(dense);
                _model = tf.keras.Model(input, output);
                _model.summary();
                // Компіляція моделі
                _model.compile(tf.keras.optimizers.Adam(), tf.keras.losses.MeanSquaredError());
                _model.summary();
            }
            catch
            {
            }
        }

        public void CreateModelRNN(int points_count)
        {
            try
            {
                // Визначення параметрів моделі
                int timeSteps = points_count; // Кількість часових кроків
                int features = 6;

                // Створення моделі LSTM
                var input = tf.keras.layers.Input(new Shape(timeSteps, features));
                var lstm1 = keras.layers.LSTM(50, return_sequences: true).Apply(input);
                var lstm2 = keras.layers.LSTM(50, return_sequences: false).Apply(lstm1);
                var dense = keras.layers.Dense(units: 25).Apply(lstm2);
                var output = keras.layers.Dense(units: 1).Apply(dense);
                _model = tf.keras.Model(input, output);
                _model.summary();

                // Компіляція моделі
                _model.compile(tf.keras.optimizers.Adam(), tf.keras.losses.MeanSquaredError());
                _model.summary();
            }
            catch
            {
            }
        }

        public void ModelTrain()
        {
            // Навчання (замінити на дані для навчання)
            // var trainX = ... ; // Підготовка даних
            // var trainY = ... ;
            //model.fit(trainX, trainY, batch_size: batchSize, epochs: numEpochs);
        }

        #region Load/Save
        public bool ModelSave(string path)
        {
            bool result = false;
            try
            {
                _model.save(path, save_format: "tf");
                result = true;
            }
            catch
            {
            }
            return result;
        }

        public bool ModelLoad(string path)
        {
            bool result = false;
            try
            {

                _model = tf.keras.models.load_model(path);
                _model.summary();
                _model.compile(tf.keras.optimizers.Adam(), tf.keras.losses.MeanSquaredError(), new string[] { "accuracy" });

                //var inputs = tf.random.normal(shape: (10, 5, 3));
                //var outputs = tf.random.normal(shape: (10, 1));
                //model.fit(inputs.numpy(), outputs.numpy(), batch_size: 10, epochs: 5, workers: 16, use_multiprocessing: true);
                result = true;
            }
            catch
            {
            }
            return result;
        }
        #endregion

    }
}
