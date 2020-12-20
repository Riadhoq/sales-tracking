import TabularData from "../components/TabularData";

export default function Products({ data }) {
  console.log();
  return (
    <TabularData
      caption={"Products"}
      headers={Object.getOwnPropertyNames(data[0])}
      values={data.map((x) => Object.values(x))}
    />
  );
}

Products.getInitialProps = async (ctx) => {
  const res = await fetch("http://localhost:5000/api/products");
  const data = await res.json();
  return { data };
};
