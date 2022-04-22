using System;

namespace ByteBank.Modelos
{
    public class Lista<T>
    {
        private T[] _itens;
        private int _proximoIndex;

        // Indexador
        public T this[int index] { get { return _itens[index]; } }
        public int Tamanho { get { return _proximoIndex; } }

        public Lista(int capacidadeInicial = 10)
        {
            _itens = new T[capacidadeInicial];
            _proximoIndex = 0;
        }

        public void Adicionar(T item)
        {
            VerificarTamanhoLista(_proximoIndex + 1);

            _itens[_proximoIndex] = item;
            _proximoIndex++;
        }

        public void Adicionar(params T[] itens)
        {
            foreach (T item in itens)
            {
                Adicionar(item);
            }
        }

        public void Remover(int index)
        {
            if (index < 0 || index >= _proximoIndex)
                throw new ArgumentOutOfRangeException(nameof(index));

            for (int i = index; i < _proximoIndex; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximoIndex--;
        }

        public void Remover(T valor, bool todos = false)
        {
            for (int i = 0; i < _proximoIndex; i++)
            {
                T itemAtual = _itens[i];

                if (itemAtual.Equals(valor))
                {
                    Remover(i);
                    if (!todos) break;
                }
            }
        }

        public Lista<T> Buscar(Predicate<T> condicao)
        {
            var novaLista = new Lista<T>();

            for (int i = 0; i < _proximoIndex; i++)
            {
                T item = _itens[i];

                if (condicao(item))
                    novaLista.Adicionar(item);
            }

            return novaLista;
        }

        private void VerificarTamanhoLista(int proximoIndex)
        {
            int tamanhoAtual = _itens.Length;

            if (proximoIndex <= tamanhoAtual)
                return;

            Array.Resize(ref _itens, tamanhoAtual * 2);
        }

        #region Enumerator

        public Enumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        public class Enumerator
        {
            private Lista<T> _lista;
            private int _index;
            public T Current => _lista[_index];

            public Enumerator(Lista<T> lista)
            {
                _lista = lista;
                _index = -1;
            }

            public bool MoveNext()
            {
                _index++;
                return _index < _lista.Tamanho;
            }
        }

        #endregion
    }
}
