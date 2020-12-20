export default function Products({ data }) {
  return <>{JSON.stringify(data)}</>;
}

Products.getInitialProps = async (ctx) => {
  const res = await fetch("http://localhost:5000/api/products");
  const data = await res.json();
  return { data };
};
